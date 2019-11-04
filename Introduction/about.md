### About C

- Strongly-typed - the languages enforces type checking on objects in the code meaning it is type-safe
- Object-oriented - C# offers the developer all the tenets of OOP such as encapsulation, inheritance, and polymorphism
- Component-oriented - C# permits the creation of software components for self-contained, self-describing packages of functionality
- Unified type system - all C# types, from primitive to reference types, inherit from a single root known as Object

A solution is a culmination of project(s) and also known as the "application" you're creating.

Documentation: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/index

### Data Types

- System.Char = a single character
- System.Decimal = used for monetary values

Conversion can be achieved e.g. `Convert.ToInt32` and performed safely with `Int32.TryParse(value, out number)`

### Statements

All statements must be terminated by a ;

A statement is calling a method or performing a calculation e.g. int myVarible = 2;

The number 2 is a literal value so it cannot be anything other than 2.

### Identifiers

Names used for namespaces, classes, methods and variables.

Case sensitive and type safe, reserved words also exist. You can only start with \_ or a letter, nothing else.

### Operators

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

?? operator https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

the + is overloaded in C# to allow string concatenation
