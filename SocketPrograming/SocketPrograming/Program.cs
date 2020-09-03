using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketPrograming
{
    class Program
    {
        public static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("server start and waiting from client");            
            Socket sockerForClient = server.AcceptSocket();
        if(sockerForClient.Connected)

            {
                NetworkStream ns = new NetworkStream(sockerForClient);
                StreamWriter sw = new StreamWriter(ns);
                Console.Write("server>> welcome client");
                sw.WriteLine("welcome to client");

                sw.Flush();

                StreamReader sr = new StreamReader(ns);
                Console.WriteLine("client >>" + sr.ReadLine());
              
                sw.Close();
                ns.Close();

            }
            sockerForClient.Close();
        
       
        }



    }
}
