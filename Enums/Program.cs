/*
 * Enumeration typse: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            Seasons a = Seasons.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");
            Console.WriteLine("-------------");

            Seasons b = (Seasons)1;
            Console.WriteLine(b);
            Console.WriteLine("------------");
            
            var c = (Seasons)4;
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
