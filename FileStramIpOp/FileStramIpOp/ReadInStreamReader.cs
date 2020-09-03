using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class ReadInStreamReader
    {
        public static void Main(string[] args)
        {
            ReadInStreamReader rs = new ReadInStreamReader();
            rs.method1();
            Console.ReadKey();

        }
        public void method1()
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.txt";
            FileInfo i1 = new FileInfo(path);

            FileStream fs = i1.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
            fs.Close();
            

        }
    }
}
