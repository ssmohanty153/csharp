using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionPrograming
{
    class Class2
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the number");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                var num2 = int.Parse(Console.ReadLine());
                var div = num / num2;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException e1)
            {
                Console.Write("" + e1.Message);
            }
            catch (FormatException e2)
            {
                Console.WriteLine(e2.Message);
            }
            catch (IndexOutOfRangeException e3)
            {
                Console.WriteLine(e3.Message);
            }
            //this represent the catch(exception)
            catch
            {

            }


        }
    }
}



    /*try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public static void Method2()
        {

            string str = null;
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }*/

