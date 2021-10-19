# CSharp Studies - Tips and Tricks!

> **Note:** Many blocks of code in the README file are in the Program.cs file where you can test at runtime.

## Syntax CSharp

### Console Application example => Program.cs

**Example:**

```C#
using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
```
1. `using System;` means that we can use classes from the `System` namespace
2. `namespace` is a used to organize your code, and it's a container for Classes and other namespaces"
3. `class` is a container for data and methods, which brings functionality to your program. Every line of code that tuns in C# must be inside a class. In this example our class have a name Program
4. `static void Main(string[] args)` this line code represent where our Program initialize

> **Note:** Every C# statement ends with a semicolon
***

## WriteLine or Write

The difference between `Console.WriteLine()`and `Console.Write()` is that `WriteLine()` prints the output with a new line each time, and `Write()` prints on the same line.

**Example:**

```C#
Console.WriteLine("Hello World!");
Console.WriteLine("I will print on a new line.");

Console.Write("Hello World! ");
Console.Write("I will print on the same line.");
```
***

## C# comments

Single-line comments start with two forward slashes `//`.

Any text between `//`and the end of the line is ignored by C# (will not be executed).

**Examples:**

```C#
// This is a comment
Console.WriteLine("Hello World");

Console.WriteLine("Hello World"); // This is a comment
```

Multi-line comments start with `/*` and ends with `*/` .

Any text between `/*` and `*/` will be ignored by C#.

**Examples:**

```C#
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World");
```