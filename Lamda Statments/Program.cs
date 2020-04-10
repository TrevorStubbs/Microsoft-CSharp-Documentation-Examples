// Using Microsofts' manual: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Statments
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5) + "\n");
            Console.ReadKey();

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e + "\n");
            Console.ReadKey();

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers) + "\n");
            Console.ReadKey();

            //Expression Lamdas//

            //No arguments
            Action line = () => Console.WriteLine();

            // 2 or more arguments
            Func<int, int, bool> testForEquliaty = (x, y) => x == y;
            Console.WriteLine(testForEquliaty(2, 5) + "\n");
            Console.ReadKey();

            //Specify input types
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(6,"trevor") + "\n");
            Console.ReadKey();


            //Statement Lamdas
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };

            greet("World");
            Console.ReadKey();
        }
    }
}
