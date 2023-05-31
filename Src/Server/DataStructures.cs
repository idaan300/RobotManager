using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RobotMananager;

public unsafe static class DataStructures {
    //TODO Packed Attribute Structs

    /// <summary>
    ///  This thing does things
    /// </summary>
    /// 

    public enum SensorDetected : byte {
        None,
        Up,
        Down,
        Left,
        Right,
    }


    public enum DetectionType : byte {
        Obstacle,
        Unit,
        Flag,
    }

    [Flags]
    enum TileData : byte {
        Empty,
        Wall,
        Base,       //Robot Spawn Point
        Flag,          
    }

    enum RobotAction {
        Wait,
        MoveToTarget,
        DoFuckAll,
        Pickup,
        Drop,
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public unsafe struct RobotData {
        Int32 ID;
        Vector2 Pos;
        Int32 CarryCapacity;
        RobotSensor SensN;
        RobotSensor SensE;
        RobotSensor SensS;
        RobotSensor SensW;

        public RobotData() {
            CarryCapacity = 100;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public unsafe struct RobotSensor {
        public SensorDetected Dir;
        public DetectionType Type;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public unsafe struct FlagData {
        Int32 ID;
        Int32 CarriedByID;            // -1 is for none, > 0 ID of robot Carrying it
        Vector2 Pos;
        Single Weight;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public unsafe struct Map {
        //Stupid C# being a stupid, stupid that cant have fixed 2d arrays

        //C/C++ Style Multi Dimentional Arrays Are Actually Array of Arrays In memmory.

        fixed byte MapData[11 * 11];

        public byte[,] Value { 
            get {

                byte[] Temp = new byte[11 * 11];
                fixed (byte* MapDataPtr = MapData) {
                    Marshal.Copy((IntPtr)MapDataPtr, Temp, 0, 11 * 11);
                }

                return Make2DArray(Temp, 11, 11);
            }
        }

        private static T[,] Make2DArray<T>(T[] input, int height, int width) {

            T[,] output = new T[height, width];
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    output[i, j] = input[i * width + j];
                }
            }
            return output;
        }
    }
}

