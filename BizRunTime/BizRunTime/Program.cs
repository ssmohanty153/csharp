using System;

namespace BizRunTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a_array ={ 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin 
            // it will run till the 
            // last element of the array 
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
        }
    }
}
