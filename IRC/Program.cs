using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace IRC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry("irc.zebra.lt");
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 6667);

                Socket server = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    server.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        server.RemoteEndPoint.ToString());

                    Console.WriteLine("...1....");
                    int bytesRec = server.Receive(bytes);
                    Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    //Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new LoginWindow(server));
                    Console.WriteLine("----1-----");
                    int bytesSent = server.Send(Encoding.ASCII.GetBytes("NICK niuksa"+Environment.NewLine));
                    Console.WriteLine(".......1...... " + bytesSent);

                    Console.WriteLine("-----2----");
                    bytesSent = server.Send(Encoding.ASCII.GetBytes("USER guest 0: * niuksa" + Environment.NewLine));
                    Console.WriteLine(".......2...... " + bytesSent);
                    //bytes = Enumerable.Repeat((byte)0, 1024).ToArray();
                    bytesRec = server.Receive(bytes);
                    Console.WriteLine(Encoding.ASCII.GetString(bytes));
                    //bytes = Enumerable.Repeat((byte)0, 1024).ToArray();
                    bytesRec = server.Receive(bytes);
                    Console.WriteLine(Encoding.ASCII.GetString(bytes));
                    //bytes = Enumerable.Repeat((byte)0, 1024).ToArray();
                    bytesRec = server.Receive(bytes);
                    Console.WriteLine(Encoding.ASCII.GetString(bytes));

                    server.Shutdown(SocketShutdown.Both);
                    server.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }



            /*Process.Start("https:///kiwiirc.com/server");*/

            Console.ReadKey();
        }

        private static void ReadingFromSocket(Socket server)
        {
            byte[] bytes = new byte[1024];
            bool exit = false;
            while(exit != true)
            {
                List<Socket> serverSocket = new List<Socket>() { server };
                bytes = Enumerable.Repeat((byte)0, 1024).ToArray();
                if (serverSocket.Any())
                {
                    try
                    {
                        Socket.Select(serverSocket, null, null, 5);
                        int bytesRec = server.Receive(bytes);
                        Console.WriteLine("{0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    }
                    catch
                    {

                    }
                }
                else
                    exit = true;
                
            }

        }
    }
}
