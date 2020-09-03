using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientSidePrograming
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExecuteClient();
        }
        public static void ExecuteClient()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAdd = ipHost.AddressList[0];
               
                IPEndPoint localEndPoint = new IPEndPoint(ipAdd, 11111);
               
                Socket sender = new Socket(ipAdd.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(localEndPoint);
                    Console.WriteLine("socket connection to {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] messagesend = Encoding.ASCII.GetBytes("Test Client<EOF>");
                    int byteSend = sender.Send(messagesend);
                    byte[] messageRecived = new byte[1024];
                    int byterecive = sender.Receive(messageRecived);
                   

                    Console.WriteLine("message from server {0}",
                        Encoding.ASCII.GetString(messageRecived, 0, byterecive)
                        );
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();


                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("socket exceptoin {}", ae.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("socket exceptoin {}", se.ToString());
                }
                
                catch (Exception e)
                {
                    Console.WriteLine("socket exceptoin {}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(" Uncxcepton {}", e.ToString());
            }

        }
    }
    
      
}
