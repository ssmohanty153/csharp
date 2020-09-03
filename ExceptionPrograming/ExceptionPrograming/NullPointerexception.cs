using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExceptionPrograming
{
    class NullPointerexception
    {
        public static void Main()
        {
            string str = null;
            try 
            { 
            
            if(str.Length==0)
            {
                Console.WriteLine("MaxLengthAttribute is zero");
            }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(""+e.Message);
            }
        }
    }
}
