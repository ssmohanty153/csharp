using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;


namespace ExceptionPrograming
{
    class DivByEven : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "divide canot be even number";
            }

        }
    }
        class Test
        {
           
           public static void Main()
            {
                Test t = new Test();
                int num = 20, den = 3,z;




                if (den % 2 > 0)
                    throw new DivByEven();

                z = num / den;
                Console.WriteLine(z);
                Console.WriteLine("program end");

                

                            }

        }
    }


