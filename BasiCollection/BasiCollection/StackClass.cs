using System;
using System.Collections.Generic;
using System.Text;

namespace BasiCollection
{
    class StackClass
    {
        static void main()
        {
            Stack<string> st = new Stack<string>();
            st.Push("ssm");
            st.Push("ssmo");
            st.Push("ssmoh");
            st.Push("ssmohn");
            st.Push("ssmohnty");
            foreach(var set in st)
            {
                Console.WriteLine(set);
            }
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());


        }
    }
}
