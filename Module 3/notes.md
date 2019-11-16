### Declaring Methods

Access Modifier

- Private: can only use within containing class
- Public: access from anywhere
- Protected: access from within class or derived classes
- Internal: access from within the assembly
- Static: class method

### Method Overloading

- Overloaded methods have the same name, and must have a unique signature
- Cannot overload when only parameters or return type changes

When you invoke the method, you have choice of which overloaded version you use. You simply provide the relevant arguments to satisfy a particular overload.

### Optional Parameters

It's important to note that you must specify all non-optional parameters first, and then list the optional parameters.

### Return

To return multiple items from a method, you can use `out` or `ref`, `ref` requires the variable to be initialised first.

Typically, methods only return one item.

### Exceptions

When a method throws an exception, the calling code must be prepared to detect and handle this exception.

The recommended strategy to follow with catch blocks is to catch more specific exceptions first, and more general exceptions last.

Create instance of the NullReferenceException class and throw the exception object

```
var ex = new NullReferenceException("The 'Name' parameter is null.");
throw ex;
```
