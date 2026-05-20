// Import the System namespace to use Console without writing System.Console
using System;

namespace MyFirstApp // A container/folder for the code to avoid naming conflicts
{
    class Program // Everything in C# lives inside a class
    {
        static void Main(string[] args) // The entry point — where your program starts. static = no object needed, void = returns nothing, args = command-line arguments
        {
            Console.WriteLine("Hello, World! Hey!!"); // Prints text to the screen followed by a newline
        }
    }
}