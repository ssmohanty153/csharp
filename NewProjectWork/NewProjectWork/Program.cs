using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewProjectWork
{
    public enum Department { HR, DEV, TESTING, QA, MANAGEMENT }
    public enum DESIGNATION { Junior, HR, SeniorHR, SOFTWATEDEVELOPER, QA, INFRA, Manager, CTO, COO }
    class Program
    {
        public static Random random = new Random();
       

        public static void Main(string[] args)
        {
           
            string[] companyName = { "Tcs", "Wipro", "MicroSoft", "Google", "bizRuntime" };
            string[] department = Enum.GetNames(typeof(Department));
            string[] DESIGNATION = Enum.GetNames(typeof(DESIGNATION));
            string companyID;
            string employeeId;
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\ProjectWork\\Employee.csv";





            int count = 0;
            // int k = 0;
            for (int i = 0; i < companyName.Length; i++)
            {
                int k = 1;
                int m = i;
                string file = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\ProjectWork\\";

                for (int j = 1; j <= 200; j++)
                {
                    string employeeName = "";

                    companyID = companyName[i];
                    employeeId = companyName[i];

                    if (j == 1)
                    {
                        file = file + companyName[i];
                        file = file + ".csv";
                        Console.WriteLine(file);
                    }
                    while (m >= 0 && k <= 200)
                    {
                        employeeName = companyName[i] + " " + k;
                        AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);
                        k++;

                    }


                    if (i == 0 && j == 1)
                    {
                        count = count + 1;
                    }
                    else
                    {
                        count = 0;
                    }
                    employeeName = companyName[i] + " " + j;

                    // Console.WriteLine(file);
                    AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], path, count);
                    // AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);
                    // AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);
                    // AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);
                    // AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);
                    // AddRecord(employeeId + (random.Next(0, 33)), employeeName, companyName[i], companyID + (random.Next(0, 33)), department[random.Next(0, 5)], DESIGNATION[random.Next(0, 5)], file, count);

                }
            }
            Console.WriteLine("Enter your data successful");

          
            Console.WriteLine("data written to file");
           // Console.WriteLine("data written to file");

            Console.ReadKey();
        }
        public static void AddRecord(string employeeId, string employeeName, string companyName, string companyId, string department, string designation, string filepath, int count)

        {

            try
            {
                using (StreamWriter file = new StreamWriter(filepath, true))
                {
                    if (count == 1)
                    {
                        file.WriteLine("employeeId".PadLeft(3).PadRight(9) + "," + "employeeName".PadLeft(3).PadRight(9) + "," + "companyName".PadLeft(3).PadRight(9) + "," + "companyId".PadLeft(3).PadRight(9) + "," + "department".PadLeft(3).PadRight(9) + "," + "designation".PadLeft(3).PadRight(9));

                    }
                    file.WriteLine(employeeId.PadRight(12) + "," + employeeName.PadRight(7) + "," + companyName.PadRight(7) + "," + companyId.PadRight(7) + "," + department.PadRight(7) + "," + designation.PadRight(7));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       

    }
}