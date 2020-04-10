/*
 * class (C# Reference): https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Program
    {
        class Child
        {
            private int age;
            private string name;

            //Default construtor
            public Child()
            {
                name = "N/A";
            }

            //Overloaded Constructor 
            public Child(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void printChild()
            {
                Console.WriteLine($"{name}, {age} years old.");
                //original had the old format ("{0}, {1} years old.", name, age)            }
            }
        }

        static void Main(string[] args)
        {
            //Instantiate the child objects using the 'new' operator
            Child child1 = new Child("Craig", 11);
            Child child2 = new Child("Sally", 10);

            //Instantiate the child objects using the 'new' operator using the default constructor
            Child child3 = new Child();

            //Call PrintChild method
            Console.WriteLine("Child #1: ");
            child1.printChild();
            Console.WriteLine("Child #2: ");
            child2.printChild();
            Console.WriteLine("Child #3: ");
            child3.printChild();

            Console.ReadKey();
        }
    }
}
