using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Windows.ApplicationModel.Background;

namespace RobotMananager;

public unsafe static class DataStructures {


    //public enum SensorDetected : byte {
    //    None,
    //    Up,
    //    Down,
    //    Left,
    //    Right,
    //}


    public enum TCPCommands : byte {
        RB_PROT_INIT = 0xAA,

        RB_PROT_UNDEFINED = 0x00,
        RB_PROT_ROBOTDATA = 0x01,
        RB_PROT_FLAGDATA = 0x02,

        RB_PROT_SETABSPOS = 0x03,

        RB_PROT_ALLYLIST = 0x04,

        RB_PROT_FLAGPICKED_UP = 0x10,

        RB_PROT_MAPDATA = 0x03,
        RB_PROT_EMGSTOP = 0xFF,
        RB_PROT_TICK = 0xBB,
    }

    //Used By The Map Renderer

    public enum VisualTileType : byte {
        Void = 0xFF,
        None = 0x00,
        Wall = 0x01,

        Unit1 = 0x03,
        Unit2 = 0x04,
        Unit3 = 0x05,
        Unit4 = 0x06,

        Spawn1 = 0x07,
        Spawn2 = 0x08,
        Spawn3 = 0x09,
        Spawn4 = 0x0A,

        Flag1 = 0X0B,
        Flag2 = 0X0C,
        Flag3 = 0X0D,
        Flag4 = 0X0E,
    }

    public enum TileType : byte {
        Void = 0xFF,
        None = 0x00,
        Wall = 0x01,
        Unit = 0x02,
        Flag = 0x03,
        Spawn = 0x04,
    }

    //[Flags]
    //enum TileData : byte {
    //    Empty,
    //    Wall,
    //    Base,       //Robot Spawn Point
    //    Flag,          
    //}

    enum RobotAction {
        Wait,
        MoveToTarget,
        DoFuckAll,
        Pickup,
        Drop,
    }

    //-------------
    //  MISC
    //-------------

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vec3f {
        public Double X, Y, Z;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vec2f {
        public Double X, Y;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vec2I {
        public Int32 X, Y;
    }

    //Struct that Contains A Struct, So Marshal.Copy and Marshal.PtrToStruct Become Unreliable
    //Manually Get The Pinned Ptr To the Struct When Converting
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RobotData {
        //Byte ;                        //Robot ID
        Vec3f Pos;                      //Current Robot Pos In Webots Each Block is 0.1f in X,Z Axis
        VisualTileType SpawnPoint;      //TileID of SpawnPoint
        Int32 CarryCapacity;            //Remaining Carry Capacity
        RobotSensor SensN;              //Robot Distance / Colission Sensor. C# Cant Have Fixed Struct Arrays So Just Make 4 Copies,
        RobotSensor SensE;              //Memory Map Is Still The Same When We Convert The Byte Payload to A Struct
        RobotSensor SensS;
        RobotSensor SensW;

        //Init Capacity To 100
        public RobotData() {
            CarryCapacity = 100;
        }
    }



    //A Robot Sensor Just Returns The Tiles it sees 1 block ahead
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct RobotSensor {
        public VisualTileType Type;
    }

    //Flag (Target) Struct
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlagData {
        public Int32 ID;        //Flag ID
        public Vec2I Pos;       //2D Vector Of Flag Pos On Map Grid
        public Byte Weight;     //Flag Weight
    }




    /// <summary>
    /// Map Data Struct, Unsafe because of fixed size byte array
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Map {
        //Stupid C# being a stupid, stupid that cant have fixed 2D arrays

        //C/C++ Style Multi Dimentional Arrays Are Arrays of Arrays In memmory and not sepperate arrays with pointer indexes

        private fixed Byte MapData[11 * 11];

        public VisualTileType GetTile(Int32 X, Int32 Y) {
            if(X > 10 || Y > 10 || Y < 0 || X < 0) throw new ("Hammond You Idiot");

            fixed (Byte* MapDataPtr = MapData) {
                Int32 Index = X * 11 + Y;
                return (VisualTileType)MapData[Index];
            }
        }

        public void SetTile(Int32 X, Int32 Y, VisualTileType Type) {
            if (X > 11 || Y > 11 || Y < 0 || X < 0) throw new("Hammond You Idiot");

            fixed (Byte* MapDataPtr = MapData) {
                Int32 Index = X * 11 + Y;
                MapDataPtr[Index] = (Byte)Type;
            }
        }

        private void MakeWallVert(Int32 StartPosX, Int32 StartPosY, Int32 Height) {
            for(Int32 i = StartPosY; i < StartPosY + Height; i++) {
                //Debug.WriteLine("ADD ENT TO:" + StartPosX + "," + i);
                SetTile(StartPosX, i,VisualTileType.Wall);
            }
        }

        private void MakeWallHor(Int32 StartPosX, Int32 StartPosY, Int32 Width) {
            for (int i = StartPosX; i <= StartPosX + Width; i++) {
                //Debug.WriteLine("ADD ENT TO:" + StartPosX + "," + i);
                SetTile(i, StartPosY, VisualTileType.Wall);
            }
        }

        /// <summary>
        /// Map Is Fixed, Hard Coded Defenitions Here
        /// </summary>
        public void FillMap() {

            for(int i = 0;i < 11;i++) {
                for (Int32 j = 0; j < 11; j++) {
                    SetTile(j, i, VisualTileType.None);
                }
            }

            fixed (Byte* MapDataPtr = MapData) {
                Byte[] Temp = new byte[11 * 11];
                Marshal.Copy((IntPtr)MapDataPtr, Temp, 0, 11*11);
                Debug.WriteLine( Utility.HexDump(Temp, 11));
            }

            //0,0 Pink Spawn: ID 1
            SetTile(0, 0, VisualTileType.Spawn1);

            //10,0 Yel Spawn: ID 2
            SetTile(10, 0, VisualTileType.Spawn2);

            //0,0 Pink Spawn: ID 1
            SetTile(0, 10, VisualTileType.Spawn3);

            //10,0 Yel Spawn: ID 2
            SetTile(10, 10, VisualTileType.Spawn4);

            //6 Vert Walls
            MakeWallVert(6, 1, 3);
            MakeWallVert(2, 2, 3);
            MakeWallVert(8, 2, 3);
            MakeWallVert(2, 6, 3);
            MakeWallVert(4, 6, 3);
            MakeWallVert(6, 6, 3);

            ////1 Hor Wall
            MakeWallHor(8, 8, 3);
        }
    }
}

