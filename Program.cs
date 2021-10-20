using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("*").PadRight(50, '*'));
            Console.WriteLine("\tCSharp Studies - Tips and Tricks!");
            Console.WriteLine(("*").PadRight(50, '*'));
            System.Console.WriteLine();

            System.Console.WriteLine("## WriteLine() or Write()\n");

            System.Console.WriteLine("Hellor World!");
            System.Console.WriteLine("I will print on a new line.");

            System.Console.Write("\nHello World! ");
            System.Console.WriteLine("I will print os the same line.");
            System.Console.WriteLine();

            System.Console.WriteLine("## Declaring variables\n");

            System.Console.WriteLine("String:");
            string name = "John";
            System.Console.WriteLine($"name => {name}");

            System.Console.WriteLine("\nInt:");
            int myNum = 15;
            System.Console.WriteLine($"myNum => {myNum}");

            System.Console.WriteLine("\nDeclaring Int without assign:");
            int myNum2;
            myNum2 = 20;
            System.Console.WriteLine($"myNum2 => {myNum2}");

            System.Console.WriteLine("\nAssign a new value to an existing variable:");
            int myNum3 = 25;
            myNum3 = 30; // myNum3 is now 30
            System.Console.WriteLine($"myNum3 => {myNum3}");

            System.Console.WriteLine("\nDouble:");
            double myDouble = 5.99D;
            System.Console.WriteLine($"myDouble => {myDouble}");

            System.Console.WriteLine("\nFloat:");
            float myFloat = 10.99F;
            System.Console.WriteLine($"myFloat => {myFloat}");

            System.Console.WriteLine("\nDecimal:");
            decimal myDecimal = 20.985M;
            System.Console.WriteLine($"myDecimal => {myDecimal}");

            System.Console.WriteLine("\nChar:");
            char myChar = 'M';
            System.Console.WriteLine($"myChar => {myChar}");

            System.Console.WriteLine("\nBool:");
            bool myBoolTrue = true;
            bool myBoolFalse = false;
            System.Console.WriteLine($"myBoolTrue => {myBoolTrue}");
            System.Console.WriteLine($"myBoolFalse => {myBoolFalse}");
            System.Console.WriteLine();
            
            System.Console.WriteLine("## Concatenation");
            System.Console.WriteLine("\nConcatenation using '+' character:");
            string name1 = "John";
            System.Console.WriteLine("Hello " + name1);

            string firstName = "John ", lastName = "Doe";
            string fullName = firstName + lastName;
            System.Console.WriteLine(fullName);
        }
    }
}
