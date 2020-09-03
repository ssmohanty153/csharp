using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionPrograming
{
    class Class1
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 7, 0, 3 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);

                }
            }
            //
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine("IndexOutOfRangeException" + e1.Message);

            }
            catch (DivideByZeroException e2)
            {
                Console.WriteLine("DivideByZeroException " + e2.Message);

            }
             //ArgumentOutOfRangeException is thrown when a method is
            // invoked and at least one of the arguments passed to the method
           // is not null and does not contain a valid value. ArgumentOutOfRangeException 
          //is used extensively by: Classes in the System.
            catch (ArgumentOutOfRangeException e3)
            {
                Console.WriteLine("ArgumentOutOfRangeException" + e3.Message);
            }
            //The finally block will execute when the try/catch
           // block leaves the execution, no matter what condition cause it.
            // It always executes whether the try block terminates normally or terminates due to an exception
            finally
            {
                for(int i=0;i<arr.Length;i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
        }

    }
}
