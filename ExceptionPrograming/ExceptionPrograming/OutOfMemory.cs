using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionPrograming
{
    class OutOfMemory
    {
        public OutOfMemory()
        {
            StringBuilder sb = new StringBuilder(15, 15);
            sb.Append("Substring #1 ");
            try
            {
                sb.Insert(0, "Substring #2 ", 1);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Out of Memory", e.Message);
            }
        }
    
}
}
