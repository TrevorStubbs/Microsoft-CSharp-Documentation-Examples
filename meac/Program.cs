/*
 * Microsoft Program Structure:  
 * https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-structure
 */

using System;
using Acme.Collections;

namespace Acme
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(10);
            stack.Push(100);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadKey();
        }
    }
}

