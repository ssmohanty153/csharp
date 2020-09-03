using System;

namespace ExceptionPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter the value of x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value of y");
            y = int.Parse(Console.ReadLine());
            if(y%2>0)
            {
                throw new ApplicationException("diviser canot be even number");
            }
            z = x / y;
            Console.WriteLine(z);





        }
            /* int[] arr = { 1, 2, 3, 45, 555 };
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
               //  Console.ReadLine();

             }
         try
         {
             Console.WriteLine(arr[7]);
         }
         catch(IndexOutOfRangeException e)
         {
             Console.WriteLine("exception out of bond" + e.Message);
         }


     }*/
        }
}
