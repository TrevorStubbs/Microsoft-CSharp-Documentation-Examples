//Microsoft Value Types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types#built-in-value-types

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Value_Types
{
    class Program
    {
        //How a structure works
        struct Location
        {
            public int x, y;
            public Location(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //Value Type Passed
        public struct MutablePoint
        {
            public int X;
            public int Y;

            public MutablePoint(int x, int y) => (X, Y) = (x, y);

            public override string ToString() => $"({X}, {Y})";
        }

        //Pass reference
        public struct TaggedInteger
        {
            public int Number;
            private List<string> tags;

            public TaggedInteger(int n)
            {
                Number = n;
                tags = new List<string>();
            }

            public void AddTag(string tag) => tags.Add(tag);

            public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
        }

        static void Main(string[] args)
        {

            //struct test
            Location a = new Location(20, 20);
            Location b = a;
            a.x = 100;
            Console.WriteLine(b.x);
            Console.ReadKey();
            Console.WriteLine("------------------------");


            //Value Test       
            var p1 = new MutablePoint(1, 2);
            var p2 = p1;
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
            Console.ReadKey();
            Console.WriteLine("--------------------------");

            //Reference Test
            var n1 = new TaggedInteger(0);
            n1.AddTag("A");
            Console.WriteLine(n1);

            var n2 = n1;
            n2.Number = 7;
            n2.AddTag("B");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();


        }

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}.");
        }
    }
}
