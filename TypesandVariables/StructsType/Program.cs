/*
 * Structure Types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct
 * This article for the difference between structs and classes:https://www.c-sharpcorner.com/blogs/difference-between-struct-and-class-in-c-sharp
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    class Program
    {

        //Struct format 
        //7.3 allows to make these imutable by using the 'readonly' keyword.
        public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }

        //Struct w/o a constructor
        public struct Coods
        {
            public double x;
            public double y;
        }
      

        static void Main(string[] args)
        {
            Coords coord = new Coords(2, 4);
            Console.WriteLine(coord);
            Console.WriteLine("---------------");
            Console.ReadKey();

            //initialize struct values without a constructor
            Coods p;
            p.x = 3;
            p.y = 4;
            Console.WriteLine($"({p.x}, {p.y})");
            Console.ReadKey();            
        }
    }
}
