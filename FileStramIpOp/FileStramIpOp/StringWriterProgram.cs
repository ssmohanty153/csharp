using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class StringWriterProgram
    {
        public static void Main(string [] args)
        {
            string text = "hello world";
            ReadData(text);

        }
        public static void ReadData(string text)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.WriteLine(text);
            sw.Close();
            StringReader reader = new StringReader(sb.ToString());
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }

        }
    }
}
