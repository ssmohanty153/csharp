using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace FileStramIpOp
{
    class FileInfoProgram
    {
        public static void Main(String[] args)
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\HareRama.txt";
            //  CreateFile(path);
            // StoringData(path);
            FatchData(path);
        }

        public static void CreateFile(string path)
        
        {
            try
            {
                FileInfo file = new FileInfo(path);
                file.Create();
                Console.WriteLine("file created successfully");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public static void StoringData(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                StreamWriter sw=file.CreateText();
                sw.WriteLine("this folder stored the Char");
                Console.WriteLine("file Stored text  successfully");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void FatchData(string path)
        {
            try
            {
                FileInfo f1 = new FileInfo(path);
                StreamReader sr = f1.OpenText();
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            catch( IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
