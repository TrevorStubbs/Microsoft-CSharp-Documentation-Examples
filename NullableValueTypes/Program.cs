/*
 * Nullable value types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //? after the keyword makes the type nullable
            int? a = 42;

            void checkForNull()
            {
                if (a is int valueOfA)
                {
                    Console.WriteLine($"a is {valueOfA}");
                }
                else
                {
                    Console.WriteLine("a does not have a value");
                }
            }

            checkForNull();
            Console.WriteLine("--------");
            a = null;
            checkForNull();
            Console.WriteLine("--------------");

            //.HasValue indicates whether an instance of a nullable value type has a value of its underlying type.
            a = 55;
            if(a.HasValue)
            {
                Console.WriteLine($"a is {a.Value}");
            }
            else
            {
                Console.WriteLine("a does not have a value.");
            }
            Console.WriteLine("--------------------");

            //You also can compare a variable of a nullable value type with null instead of using the HasValue property
            if(a != null)
            {
                Console.WriteLine($"a is {a.Value}");
            }
            else
            {
                Console.WriteLine("a does not have a value.");
            }
            Console.WriteLine("--------------");

            a = null;

            //use ?? or Nullable<T>.GetValueOrDefault() to turn the null type back to it's default type
            int b = a ?? 4;  
            /* This last digit has to be of the default type but it has to be there. 
             * The output will be the original value. But if it was a 'null' it will make 
             * the last digit the value. */
            Console.WriteLine($"b is {b}");
            Console.WriteLine("--------------");

            int? c = 125;
            int d = c.GetValueOrDefault();
            Console.WriteLine($"c is {c}");

            //Unary and binary operations with a 'null' will output a 'null'.
            int? e = 10;
            int? f = null;
            int? g = 10;

            Console.WriteLine(e++);
            Console.WriteLine(e * g);
            e = f + e;
            Console.WriteLine((object)e ?? "null");
            Console.WriteLine("----------");

            //Comparison operatiors: If one or both operands are 'null' the result will always be false.
            a = 10;
            Console.WriteLine($"{a} >= null {a >= null}"); //False
            Console.WriteLine($"{a} >= null {a < null}"); //False
            Console.WriteLine($"{a} >= null {a == null}"); //False

            e = null;
            f = null;
            Console.WriteLine($"null >= null is {e >= f}"); //False

            /*
             * For the equality operator ==, if both operands are null, the result is true, if only one of 
             * the operands is null, the result is false; otherwise, the contained values of operands are 
             * compared.
             * 
             * For the inequality operator !=, if both operands are null, the result is false, if only one 
             * of the operands is null, the result is true; otherwise, the contained values of operands are 
             * compared.
             */ 

            Console.WriteLine($"null == null is {e == f}"); //True
            Console.WriteLine($"a != null is {a!=e}"); //True
            Console.WriteLine("----------");

            /*
             * Boxing and unboxing:
             * If HasValue returns false, the null reference is produced.
             * If HasValue returns true, the corresponding value of the underlying value type T is boxed, not the instance of Nullable<T>.
             */
             
            int aBoxingExample = 41;
            object aBoxed = aBoxingExample;
            int? aNullable = (int?)aBoxed;
            Console.WriteLine($"Value of aNullable: {aNullable}");

            object aNullableBoxed = aNullable;
            if(aNullableBoxed is int valueofA)
            {
                Console.WriteLine($"aNullableBoxed is boxed int: {valueofA}");
            }
            Console.WriteLine("------------");

            //How to identify a nullable value type (don't box it)
            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");
            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");

            //Use this code to determine if an instance is of a nullable type:
            bool IsOfNullableType<T>(T o)
            {
                var type = typeof(T);
                return Nullable.GetUnderlyingType(type) != null;
            }

            int? z = 14;
            Console.WriteLine(IsOfNullableType(z));

            int y = 17;
            Console.WriteLine(IsOfNullableType(y));


            Console.ReadKey();



        }
    }
}
