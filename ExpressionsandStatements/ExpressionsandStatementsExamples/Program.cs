/*
 * C# Statements: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsandStatementsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local variable declaration
            void declarations()
            {
                int a;
                int b = 2, c = 3;
                a = 1;
                Console.WriteLine(a + b + c); //output a + (b + c) = 6
            }

            // constant declaration
            void constantDeclaration()
            {
                const float pi = 3.1415927f; //must use 'f' if using a float.
                const int r = 25; //radius
                Console.WriteLine(pi * r * r); //pi(r)^2
            }

            // Expression statement
            void expressions()
            {
                int i;
                i = 123;
                Console.WriteLine(i); //i
                i++;
                Console.WriteLine(i); //i+1
            }

            // 'if' statement
            void ifStatement()
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("No arguments"); //statemente if this
                }
                else
                    Console.WriteLine("One or more arguments"); // else this (if only 1 statement no need for {}
            }

            // 'switch' statement
            void switchStatment()
            {
                int n = args.Length;
                switch(n)
                {
                    case 0: // use : after the case
                        Console.WriteLine("No Arguments");
                        break; // need to break out of this complete statement
                    case 1:
                        Console.WriteLine("One Argument");
                        break;
                    default: //if not any of the previous cases then do this
                        Console.WriteLine($"{n} arguments");
                        break;
                }
            }

            // while statement
            void whileStatment()
            {
                int i = 0;
                while(i < 10)
                {
                    Console.Write($"{i} ");
                    i++; // Don't forget to incrment your counter or you'll end up in an ∞ loop
                }
                Console.WriteLine();
            }

            // do while statement
            void doWhileStatement()
            {
                string s;
                do
                {
                    Console.WriteLine("I will repeat what you say: ");
                    s = Console.ReadLine();          
                    Console.WriteLine(s);
                } while (!string.IsNullOrEmpty(s));
            }

            // for statement
            void forStatement()
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            // foreach statement
            void forEachStatement()
            {
                int[] box = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                foreach(int apple in box)
                    Console.Write($"{apple} ");
            }

            // TODO break, continue, goto, return, yield, try and throw, checked and unchecked, lock, using

            declarations(); // 6
            constantDeclaration(); //~1963.5
            expressions(); // 123 - 124
            ifStatement(); // No arguments
            switchStatment(); // No arguments
            whileStatment(); // count 0 to 9
            doWhileStatement(); // repeat user input
            forStatement(); // count 0 to 9
            forEachStatement(); // count 1 to 10
            Console.ReadLine();

        }
    }
}
