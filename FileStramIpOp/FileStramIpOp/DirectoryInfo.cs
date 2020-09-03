using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace FileStramIpOp
{
    class DirectoryInfoProgram
    {
        public static void Main(string[] args) 
        {
            string folderPath = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\HareRam";
           // Create(folderPath);
            Delete(folderPath);



        }
        public static void Create(string path)
        {
           DirectoryInfo di = new DirectoryInfo(path);

            try
            {
                if (di.Exists)
                {
                    Console.WriteLine("Diretory already exists");
                    return;
                }

                di.Create();
                Console.WriteLine("directory create successfl");
            }
            catch( Exception e)
            {
                Console.WriteLine(e.ToString());
            }



        }
        public static void Delete(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            try
            {
                if (di.Exists)
                {
                    di.Delete();
                    Console.WriteLine("delete the folder successfully");
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing wrong"+e.ToString());
            }



        }

    }
}
