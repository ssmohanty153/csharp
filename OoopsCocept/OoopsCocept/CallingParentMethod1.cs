using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsCocept
{
    public class CallingParentMethod
    {
        public void Test()
        {
            Console.WriteLine("parent");
        }
        public virtual void Show()
        {
            Console.WriteLine("parent show");
        }
        public virtual void Display()
        {
            Console.WriteLine("parent display");
        }
    }

    public class Child : CallingParentMethod
    {
        public override void Show()
        {
            Console.WriteLine("child method show");
        }
        public override void Display()
        {
            Console.WriteLine("child class display");
        }
        public void PShow()
        {
            base.Show();
        }
    }
    public class CallingParentMethod1
    { 
        public static void Main(string[] args)
        {
            Child o = new Child();
            CallingParentMethod r = o;//call by reference
            o.Show();
            o.Display();
            r.Show();
            r.Test();
            CallingParentMethod c = new CallingParentMethod();
            c.Test();
            c.Show();

            o.PShow();
            Console.ReadKey();
        }
    }
}
