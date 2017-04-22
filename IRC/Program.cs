using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

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
            //Process.Start("https:///kiwiirc.com/server"); 

            try
            {
                TcpClient server = new TcpClient("irc.zebra.lt", 6667);
                try
                {
                    Console.WriteLine("Socket connected to {0}", server.Client.RemoteEndPoint.ToString());
                    Console.WriteLine(Reading(server));

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LoginWindow(server));

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

            Console.ReadKey();
        }
        public static string Reading(TcpClient server)
        {
            byte[] bytes = new byte[1024];
            NetworkStream reader = server.GetStream();
            StringBuilder data = new StringBuilder();
            do
            {
                int Recvbytes = reader.Read(bytes, 0, bytes.Length);
                data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
                System.Threading.Thread.Sleep(1000);
            } while (reader.DataAvailable);
            return data.ToString();
        }
    }
}
