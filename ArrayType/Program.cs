using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-demensional array
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };

            // Alt syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Declare a 2 dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set elements in a 2 dimensional array
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Declare a jagged array
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
