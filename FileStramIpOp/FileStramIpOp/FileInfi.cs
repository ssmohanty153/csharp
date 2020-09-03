using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStramIpOp
{
    class FileInfi
    {
        public static void Main(string[] args)
        {
            FileInfi fi = new FileInfi();
            fi.ReadString();
            Console.ReadKey();
        }
        public void ReadString()
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.txt";
            FileInfo f1 = new FileInfo(path);

            FileStream fs = f1.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

             byte[] fileBytes = new byte[fs.Length];
           
            int numBytesToRead = (int)fileBytes.Length;

            int count = 0;
            
            while (numBytesToRead > 0)
            {
                int n = fs.Read(fileBytes, count, numBytesToRead);

                if (n == 0)
                {
                    break;
                }

                count = count+n;
                numBytesToRead = numBytesToRead-n;
            }
        

            //convert string to UNF8.getString in encoding
            string str = Encoding.UTF8.GetString(fileBytes);
            Console.WriteLine("str is " + str);

            //close the costly resources
            fs.Close();
        }
    }
}
