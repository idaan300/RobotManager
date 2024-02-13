using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;               //required
using System.Net.Sockets;       //required
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RobotMananager;

public class TCPServerManager {

    readonly IPAddress IPAddr;
    readonly List<TCPServer> ServerInstances = new();

    public TCPServerManager(String Address, UInt16 Port, Byte NumOfInstances) {
        IPAddr = IPAddress.Parse(Address);


        //Add TCPListener Instances
        for (UInt16 i = 0; i < NumOfInstances; i++)
            ServerInstances.Add(new(IPAddr, (UInt16)(Port + i)));

        Console.WriteLine(GetType().FullName + "Init OK");
    }

    public void Start() {
        Console.WriteLine("[TCPServerManager] Start Servers");
        ServerInstances.ForEach(x => x.Start());
    }

    public void Stop() {
        Console.WriteLine("[TCPServerManager] Start Servers");
        ServerInstances.ForEach(x => new Thread(() => x.Start()).Start());
    }



    private class TCPServer {

        private readonly TcpListener Listener;
        private Socket TCPSocket;

        private Boolean Run = true;

        public TCPServer(IPAddress Address, UInt16 Port) {

            Listener = new(Address, Port);

            Console.WriteLine(GetType().FullName + "Init OK");
        }

        public void Start() {
            Listener.Start();
            Console.WriteLine("[TCPListener] Start, Local Endpoint is: " + Listener.LocalEndpoint);
            Console.WriteLine("[TCPListener] Waiting For Connection...");

            //Blocking Method, Thread Waits Here Until A Client Connection is started
            TCPSocket = Listener.AcceptSocket();

            Console.WriteLine("[TCPListener] Connection Established...");
            MainLoop();

        }



        private void MainLoop() {
            while (Run) {
                Byte[] Buffer = new Byte[128]; //Just Hardcode not like packets will be this big

                //Blocking
                Int32 BytesRecieved = TCPSocket.Receive(Buffer);

                Console.WriteLine("[TCPSocket] Recieved " + BytesRecieved + " Bytes");

                for (int i = 0; i < BytesRecieved; i++)
                    Console.Write(Convert.ToChar(Buffer[i]));

                //Vec3f temp = new Vec3f();

                while (Run) {

                    ASCIIEncoding asen = new ASCIIEncoding();

                    //temp.x += 0.001;
                    //temp.z += 0.001;

                    //String Hamood = "Free Bing Chilling No virus\n\0 ";

                    //String Hamood = Shit.PadRight(128);

                    //char[] buffer = new char[128];

                    //buffer = Hamood.ToCharArray();

                    Thread.Sleep(50);

                    //TCPSocket.Send(getBytes(temp));
                    //And Again... I-It Just Works....
                }





            }
        }


        private void DecodePacket(Byte[] Packet, Int32 PacketLen) {

            switch (Packet[0]) {

                //TODO Enum
            }



        }



        public void Stop() { }

    }



}