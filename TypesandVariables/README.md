# [Types and Variables](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables)

## [Value Types](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/Value%20Types)
- A variable of a value type contains an instance of the type.
### Built in Value Types
- Signed integral: `sbyte`, `short`, `int`, `long`
    - Can be negative but total positive number is reduced
    - First bit defines if its positive or negative
- Unsigned integral: `byte`, `ushort`, `uint`, `ulong`
    - First bit is available for use but it can't be a negative number.
- Unicode characters: `char`
- IEEE binary floating-point: `float`, `double`
    >  The IEEE Standard for Floating-Point Arithmetic (IEEE 754) is a technical standard for floating-point arithmetic established in 1985 by the Institute of Electrical and Electronics Engineers (IEEE). <sub>[1](https://en.wikipedia.org/wiki/IEEE_754)</sub>
- High-precision decimal floating-point: `decimal`
- Boolean: `bool`

### User Defined Value Types
- [Enum types](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/EnumType)
    - Named constants of underlying integral types
- [Struct Types](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/StructsType)
    - A value type that can encapsulate data and related functionally
    - A lightweight class that is a value type
- [Nullable Value Type](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/NullableValueTypes)
    - Extentions of all other value types with a `null` value

## Reference Types
- Variable of reference types store references to their data.
    - 2 variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable.

### C# Reference Types
- [Class Type](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/ClassType)
- [Interface Type](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/InterfaceType)
- [Array Type](https://github.com/TrevorStubbs/Microsoft-CSharp-Documentation-Examples/tree/master/TypesandVariables/ArrayType)
- Delegate Type
    - *TODO Read and understand delegates.*