using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp6
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; } = "";
        public Person(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;

        }
        /* public override string ToString()
         {
             return FirstName + " " + LastName;
         }*/
        //public override string ToString() => FirstName + " " + LastName;
        //or
        public override string ToString() => $"{FirstName} and   {LastName}";


        /* public string AllCops()

         {
             FirstName = FirstName.ToUpper();
             LastName = LastName.ToUpper();
             return ToString();
         }*/

        //or

        public string AllCops() => ToString().ToUpper();



        public Person(string firstname, string middleName,string lastName)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.MiddleName = middleName;

        }

    }
}
