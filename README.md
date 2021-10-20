# CSharp Studies - Tips and Tricks!

> **Note:** Many blocks of code in the README file are in the Program.cs file where you can test at runtime.

## Index

- [CSharp Studies - Tips and Tricks!](#csharp-studies---tips-and-tricks)
  - [Index](#index)
  - [Syntax C](#syntax-c)
    - [Console Application example => Program.cs](#console-application-example--programcs)
  - [WriteLine or Write](#writeline-or-write)
  - [C# comments](#c-comments)
  - [C# variables](#c-variables)
    - [Declaring (creating) variables](#declaring-creating-variables)
  - [Constants variable](#constants-variable)
  - [Other variables](#other-variables)
  - [Concatenation](#concatenation)
  - [Declare many variables](#declare-many-variables)
  - [General rules for constructing variables](#general-rules-for-constructing-variables)

## Syntax C#

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
***

## C# variables

Variables ate containers for storing data values. In C#, there are different types of variables (defined with different keywords), for example:

- `int` - stores integers (whole numbers), without decimals, such `123` or `-123`.
- `double` - stores floating point numbers, with decimals, such as `19.99` or `-19.99`.
- `char` - stores single characters, such as `'a'` or `'B'`. Char values are surrounded by single quotes.
- `string` - stores text, such as `"Hello World"`. String values are surrounded by double quotes
- `bool` - stores values with two states: `true` or `false`

### Declaring (creating) variables

To create a variable, you must specify the type and assign it a value:

**Syntax**
> *type variableName = value;*

- `type` - C# is a strongly typed language. Every variable and constant has a type, as does every expression thar evaluates to a value. Every method declaration specifies a name, the type and kind (value, reference or output) for each input parameter and for the return value. - font: docs.microsoft.com
- `variableName` - is the name of the variable (such as **x** or **name**)

**Example:**

- `string`
```C#
string name = "John";
Console.WriteLine(name);
```
- `int`
```C#
int myNum = 15;
Console.WriteLine(myNum);
```
- Declare a variable without assigning the value
```C#
int myNum;
myNum = 20;
Console.WriteLine(myNum);
```
- Assign a new value to an existing variable
```C#
int myNum = 20;
myNum = 30; // myNum is now 30
Console.WriteLine(myNum);
```

## Constants variable

You can declare a variable with the type `const`, which means unchangeable and turn this a `read-only` variable.

**Example:**
```C#
const int myNum = 15;
myNum = 20; // throws an error
```

## Other variables

Declaring variables of other types.

**Examples:**
```C#
int myNum = 10;                 // type Int
double myDoubleNum = 5.99D;     // type Double
float myFloatNum = 10.99F;      // type Float
decimal mtDecimalNum = 25.987M; // type Decimal
char myLetter = 'B';            // type Char
bool myBoolTrue = true;         // type Bool
bool myBoolFalse = false;       // type Bool
string myText = "Hello World!"; // type String
```

## Concatenation

You can combine many `texts` and `variables` using the character `+` .

**Some examples:**

- Combine `text` with `variable`
```C#
string name = "John";
Console.WriteLine("Hello " + name);
```
- Combine variables
```C#
string firstName = "John ", lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);
```
- Combine `text` with number type variables
```C#
int myNum = 10;
Console.WriteLine("Print number " + 10); // Print number 10
```
> **Note:** during a concatenation with exist texts or variables `string`, all `output` turn a `string`
- Numeric values, the `+` character works as a mathematical operator
```C#
int x = 5;
int y = 6;
Console.WriteLine( x + y ); // Print the value of x + y, which is 11
```

## Declare many variables

To declare more than one variable of the same `type`, use a comma-separated list..

**Example:**
```C#
int x = 5, y = 10, z = 130;
Console.WriteLine( x + y + z );
```

## General rules for constructing variables

- Names can contain letters, digits and undescore character `_`
- Names must begin with a letter
- Names should start with a lowercase letter and it cannot contain whitespace
- Names are case sensitive `"myVar"` and `"myvar"` are different variables
- Reserved words like `int` or `double` cannot be used as names