using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Enum;
public enum days
{
    monday, tuesday, wednesday, thursday, friday, saturday, sunday
}
public enum day3
{
    monday = 1, tuesday, wednesday, thursday, friday, saturday, sunday
}
public enum day4
{
    monday = 1, tuesday = 11, wednesday = 21, thursday = 31, friday = 41, saturday = 51, sunday = 61
}
namespace Enum
{
   
    class Class1
    {
        public static day4 meetingdate
        {
            get;
            set;
        } = day4.monday;//(days).1;
       public static void Main()
        {
            //// days d = 0;
            // Console.WriteLine(d);
            //its only print first value(only 0) 
            //if you pass 1 instade of 0 you get 1;
            // days d1 = 1;
            days d = (days)3;
            Console.WriteLine(d);
            days d2 = days.thursday;
            Console.WriteLine(d2);
            days d3 = days.saturday;
            Console.WriteLine((int)d3);
            //if you want to change the index value you do it
            // see in day3 enum

            day3 d6 = day3.saturday;
            Console.WriteLine((int)d6);
            // youn also specefy the enum index in separatly
            //see day4

            day4 d7 = day4.saturday;
            Console.WriteLine((int)d7);
            // to get

            /*foreach (var i in Enum.GetVlaues(typeof(day4)))
            {
                Console.WriteLine(i);
            }
            foreach(string s in Enum.GetName(typeof(days)))
               {

                Console.WriteLine(s);
               }*/
            Console.WriteLine(meetingdate);
            meetingdate = day4.friday;
            Console.WriteLine(meetingdate);
            foreach( int i in Enum.GetValues())
            {

            }





        }
    }
}
