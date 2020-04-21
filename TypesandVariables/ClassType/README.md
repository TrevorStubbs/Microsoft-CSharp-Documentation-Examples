# [Class Reference Type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class)

## Declaring and Inheriting Classes
- `class` keyword is used to define the class
- Only single inheritance is allowed. 
    - But a class can inherit from multiple interfaces.

- No inheritance
    ```C#
    class ClassA
    {
        //Class Implementation
    }
    ```
- Single class inheritance
    ```C#
    class DerivedClass : BaseClass 
    {
        //Class Implementation
    }
    ```
- No class inheritance, implemntation of 2 interfaces
    ```C#
    class ImplClass : IFace1, IFace2 
    {
        //Class Implementation
    }
    ```
- Single class inheritance, implemtnes 1 interface
    ```C#
    class ImplDerivedClass : BaseClass, IFace1
    {
        //Class Implementation
    }
    ```
