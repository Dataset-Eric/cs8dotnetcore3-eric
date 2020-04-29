using System;
using static System.Console;

namespace BoolOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"AND  | a     | b    ");
            WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR   | a     | b    ");
            WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR  | a     | b    ");
            WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
            Console.WriteLine("Hello World!");
        }
        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
