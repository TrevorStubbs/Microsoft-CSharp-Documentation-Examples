# [Interface Type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)

# What is an Interface
- An interface defines a contract.
- It's a collection of method and property declarations.
- Any `class` or `struct` that implements an interface must provide implementation for the defined methods and properties.

# Interface Naming
- use the `interface` keyword then `I[Name]` - ie 
```C#
interface IPoint
```

# Interface inheritance rules
- An interface can inherit from any number of interfaces 
```C#
interface ICoord : IPoint
```
- It can not inherit from a class at all ~~`interface ICoord : Point`~~

# Using an interface while declaring a class
- use `:` to inherit the interface contract
```C#
class Point : IPoint
```
- a class can inherit from any number of interfaces
```C#
class Coord : ICoord : IPoint
```
