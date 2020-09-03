using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class StringReaderProgram
    {
        public static void Main(String [] args)
        {
            string st = "hari is a good boy";
            //using full class name call method
            StringReaderProgram.ReadString(st);
        }
        public static void ReadString(string st)
        {
           
            StringWriter str = new StringWriter();
            
            str.WriteLine(st);
            str.Close();
            StringReader sr = new StringReader(str.ToString())
;
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
