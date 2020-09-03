using CsvHelper;
using ProjectWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;

namespace FileStramIpOp
{
    public enum Department { HR, DEVELOPER, TESTING, QUALITYANALYST, Businessan }
    class DirectoryInfoProgram
    {
        public static void Main(string[] args)
        {

            string folderPath = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\ProjectWorkfolder";
            CreateFolder(folderPath);

            string filePath = "\\subhransu.csv";
            string path = string.Concat(folderPath, filePath);
            CreateFile(path);

            CreateCostCategory();

            Console.ReadKey();
        }
        public static void CreateFolder(string path)
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
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
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


        private static void CreateCostCategory()
        {
            var data = new[]
               {
                new Company { EmpName = "subasish", id = 1,CompanyName="wipro",MobileName="7978794586",Email="ssmohanty153@gmail.com"},
                 new Company { EmpName = "ssm", id = 2,CompanyName="wipro",MobileName="7978794",Email="ssmohanty@gmail.com"},
                  new Company { EmpName = "subasish", id = 3,CompanyName="",MobileName="7978794586",Email="ssmohanty13@gmail.com"},
                   new Company { EmpName = "subasish", id = 4,CompanyName="",MobileName="7978794586",Email="ssmohanty53@gmail.com"},
                 new Company { EmpName = "subasish", id = 5,CompanyName="",MobileName="7978794586",Email="ssmohanty15@gmail.com"},
                
            };

            string strFilePath = @"C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.csv";
            string strSeperator = ",";
            StringBuilder sbOutput = new StringBuilder();
            int ilength = data.GetLength(0);
            for (int i = 0; i < ilength; i++)
            {
                string csvLine = data[i].EmpName + "," + data[i].id.ToString() + "," + data[i].CompanyName + "," + data[i].MobileName + "," + data[i].Email;
                sbOutput.AppendLine(string.Join(strSeperator, csvLine));
            }
            

            // Create and write the csv file
            File.WriteAllText(strFilePath, sbOutput.ToString());

            // To append more lines to the csv file
            File.AppendAllText(strFilePath, sbOutput.ToString());
        }
    }
}
