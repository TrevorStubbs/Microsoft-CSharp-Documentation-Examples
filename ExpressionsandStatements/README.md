# [Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/expressions) and [Statements](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements)


## Expressions:
- Are constructed from operands and operators.
    - C# operators: `+`, `-`, `*`, `/`, and `new`

- When an expression contains multiple operators, the *precedence* of the operators controls the order in which the expression is evaluated
    - ie `x + y * z` is evaluated as `x + (y * z)`
- If an operand occurs between 2 operators of the sam *precedence* then the *associativity* of the operators controls the order
    - All binary operators (except `=` and `??`(null-coalescing)) are *left-associative*.
        - `x + y + z` == `(x + y) + z`
    - Assignment operators (`=`) are *right-associative*
        - `x = y = z` == `x = (y = z)`
- Most operators can be Overloaded
    - *TODO* look up how that can work

---
## Statements:
- The actions of a program are expressed by using statements
### Different kinds of Statements
- A *block* permits multiple statements to be written in context where a single statement is allowed.
    - list all the statements between `{` and `}`
- Declaration Statements: 
    - used to declare local variables and constants
     ```C# 
     int a = 0;
     ```
- Expression Statements:
    - used to evaluate expressions
    ```C#
    a + b
    ```

    - Expressions that can be used as statements include:
        - Method invocation
        - Object allocations using the `new` operator
        - Assignments using `=` and the compound assignment operators.
            - `+=` (compound addition assignment operator)
            - `-=` (compound subtraction assignment operator)
            - `*=` (compound multiplication assignment operator)
            - `/=` (compound division assignment operator)
            - `%=` (compound modulo assignment operator)
        - Increment and decrement operations
            - `++` and `--`
        - `await` expression
            - TODO Look up this expression

-  Selection Statements
    - used to select one of any number of possible statements (flow control)
        - using `if`, `else if`, `else` and `switch` keywords
    ```C#
    if(a > b)
    {
        // run this block
    }
    else if ( a == b)
    {
        //run this block
    }
    else
    {
        //run this block
    }
    ```

- Iteration Statements
    - used to execute an embedded statement repeatedly
        - `while`, `do`, `for`, and `foreach`
    ```C#
    while(true) //If this is true
    {
        //Do this statement
    }

    do
    {
        //Do this statement once no matter what.
    }
    while(true) //and if true do it again
    
    for(int i = 0; i <10; i++)
    {
        //While `i` is less than 10 do this statement then count up by 1
    }

    foreach(apple in box)
    {
        //for each apple in the box do this statement
    }
    ```
    
- Jump statements
    - are used to transfer control
        - `break`, `continue`, `goto`(try not to use this), `throw`, `return` and `yield`

- try...catch and try...finally
    - used to catch exceptions
    - TODO full review of try catch blocks

- `checked` and `unchecked`statements
    - used to control the overflow-checking context for integral-type arithmetic operations and conversions.

- `lock` statements
    - used to obtain the mutual-exclusion lock for a given object, execute a statement, and then release the lock

- `using` statements
    - used to obtain a resource, execute a statement, and then dispose of that resource.

### [code examples](TODO)

