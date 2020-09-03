using System;

namespace TypeCast
{
     class Animal
     {
         public void Eat() => System.Console.WriteLine("Eating.");
         public override string ToString() => "I am an animal.";
     }

     class Reptile : Animal { }
     class Mammal : Animal { }

     class Program
     {
        public static void Main(string[] args)

         {
             Test(new Animal());

           
         Console.WriteLine("Press any key to exit.");
          Console.ReadKey();
         }

         static void Test(Animal a)
         {
             
             Reptile r = (Reptile)a;
         }
     }
 


    

   /* public class Person
    {
        // Constructor that takes no arguments:
        public Person()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }
    class TestPerson
    {
        static void Main()
        {
            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

//o/p

*/
   /*unknown
Sarah Jones
Sarah Jones*/



}
