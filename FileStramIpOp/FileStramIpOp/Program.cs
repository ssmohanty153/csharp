using System;
using System.IO;

namespace FileStramIpOp
{
    class Program
    {
        public static void Main(string[] args)
        {
            FilrHandlerClass fl = new FilrHandlerClass();
            fl.Date();
            Console.WriteLine("please enter the key foe exists");
            Console.ReadKey();
        }
    }
    public class FilrHandlerClass
    {
        public void Date()
        {
            string path = "C:\\Users\\ssmoh\\OneDrive\\Desktop\\subhransu.txt";
            StreamWriter st=new StreamWriter(path);
            Console.WriteLine("please enter the string what you want to enter");
            string str = Console.ReadLine();
            st.WriteLine(str);
            st.Flush();
            st.Close();
        }
    }
}
