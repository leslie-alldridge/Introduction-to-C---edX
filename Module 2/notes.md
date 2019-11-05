### If Statements

Single line if statements are supported, but curly braces are recommended as best practice

If, else, If else and switch statements are all supported

Switch statements must have break statements so it can compile

### Repetition

C# supports for loops, while loops and do loops

If the size of the collection or array changes during runtime, you can use a foreach loop as it will help prevent index out of bounds errors.

```
string[] names = new string[10];

// Process each name in the array.
foreach (string name in names)
{
    // Code to execute.
}
```
