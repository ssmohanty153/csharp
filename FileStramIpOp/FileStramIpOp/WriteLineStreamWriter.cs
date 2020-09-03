using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class WriteLineStreamWriter
    {
        public static void Main(string [] args)
        {
            WriteLineStreamWriter ws = new WriteLineStreamWriter();
            ws.WriteText();

        }
        public void WriteText()
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.txt";
            FileInfo fi = new FileInfo(path);
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hare rama hare rama");
            sw.Close();

        }
    }
}
