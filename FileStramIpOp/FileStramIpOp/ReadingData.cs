using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class ReadingData
    {
        public static void Main(string [] args)
        {
            ReadingData rd = new ReadingData();
            rd.ReadFile();
         //   Console.ReadKey();
        }
        public void ReadFile()
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.txt";
            
            StreamReader sr = new StreamReader(path);
            Console.WriteLine("The text inside file is:");
            // seek  is used to set the current position file stream to given value.

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

            while(str!=null )
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }
    }
}
