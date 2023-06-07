using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;      //required
using System.Net.Sockets;    //required
using System.Drawing.Imaging;
using System.Diagnostics;

namespace RobotMananager;




public class TCPServer {

    readonly TcpListener Server; 
    readonly IPAddress IPAddr;

    public TCPServer(String Address, UInt16 Port) {
        IPAddr = IPAddress.Parse(Address);
        Server = new(IPAddress.Any, Port);
    }

    public void Start() {


                new Thread(() => {

                    try {

                    
                    // use local m/c IP address, and 
                    // use the same in the client

                    /* Initializes the Listener */
                    TcpListener myList = new TcpListener(IPAddr, 8001);

                    /* Start Listeneting at the specified port */
                    myList.Start();

                    Debug.WriteLine("The server is running at port 8001...");
                    Debug.WriteLine("The local End point is  :" +
                                      myList.LocalEndpoint);
                    Debug.WriteLine("Waiting for a connection.....");

                    Socket s = myList.AcceptSocket();
                    Debug.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    Debug.WriteLine("Recieved...");
                    for (int i = 0; i < k; i++)
                        Debug.Write(Convert.ToChar(b[i]));

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("The string was recieved by the server."));
                    Debug.WriteLine("\nSent Acknowledgement");
                    /* clean up */
                    s.Close();
                    myList.Stop();

                }
            catch (Exception e) {
                Debug.WriteLine("SERVER ERROR..... " + e.Message);
            }

        }).Start();
    
    }



        public void Client() {
            new Thread(() => {
                try {
                    TcpClient tcpclnt = new TcpClient();
                    Debug.WriteLine("Connecting.....");

                    tcpclnt.Connect("127.0.0.1", 8001);
                    // use the ipaddress as in the server program

                    Debug.WriteLine("Connected");
    

                    String str = "Do you smoke a lot?\n";
                    Stream stm = tcpclnt.GetStream();

                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(str);
                    Debug.WriteLine("Transmitting.....");

                    stm.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);

                    for (int i = 0; i < k; i++)
                        Debug.Write(Convert.ToChar(bb[i]));

                    tcpclnt.Close();
                }

                catch (Exception e) {
                    Debug.WriteLine("CLIENT ERORR..... " + e.Message);
                }
            }).Start();
        }
}

    //Task ServerThread = new Task(() => {

    //    while (true) {
    //        TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

    //        NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

    //        byte[] hello = new byte[100];   //any message must be serialized (converted to byte array)
    //        hello = Encoding.Default.GetBytes("hello world");  //conversion string => byte array

    //        ns.Write(hello, 0, hello.Length);     //sending the message

    //        while (client.Connected)  //while the client is connected, we look for incoming messages
    //        {
    //            ns = client.GetStream(); //networkstream is used to send/receive messages
    //            byte[] msg = new byte[1024];     //the messages arrive as byte array
    //            ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
    //            Debug.WriteLine(msg.ToString()); //now , we write the message as string
    //        }
    //    }
    //});





//    //Itterate Through Each Robot And Update, Action, Pos Etc...
//    private async void OnUpdate() {

//    }
//}









//namespace ServerTest {
//    class Program {
//        static void Main(string[] args) {

//            // we set our IP address as server's address, and we also set the port: 9999

//            server.Start();  // this will start the server

//            while (true)   //we wait for a connection
//            {
//                TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

//                NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

//                byte[] hello = new byte[100];   //any message must be serialized (converted to byte array)
//                hello = Encoding.Default.GetBytes("hello world");  //conversion string => byte array

//                ns.Write(hello, 0, hello.Length);     //sending the message

//                while (client.Connected)  //while the client is connected, we look for incoming messages
//                {
//                    byte[] msg = new byte[1024];     //the messages arrive as byte array
//                    ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
//                    Debug.WriteLine(encoder.GetString(msg).Trim('')); //now , we write the message as string
//                }
//            }

//        }
//    }
//}