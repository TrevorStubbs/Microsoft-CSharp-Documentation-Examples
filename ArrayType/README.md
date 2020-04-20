# [Array Type](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)

## Arrays (Reference Type)
- You can store multiple variables of the same type in an array.
    - You can declare an array by specifying the type of its elements. ie `int[] arrayName;`
    - You can store elements of any type by using `object[] arrayName;`

## Array Properties in C#
- The number of dimensions and the length of each dimension are established when the array is instantiated. They can not be changed during the lifetime of the instance.
- The default values of a numberic array are set to `0`. Reference elements are set to `null`.
- A jagged array is array of arrays and its elements are reference types
    - ie they are initialized to `null`.
- Arrays are zero indexed
    - an array with `n` elements is indexed from `0` to `n-1`.
- Array elements can be of any type include an array type.
- Array types are reference types derived from the abstract base type Array.