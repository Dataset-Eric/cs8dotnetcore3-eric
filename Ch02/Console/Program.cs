using System;
using static System.Console;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pressez n'importe quelle touche");
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Vous avez appuyer sur la touche {0} {1} {2}", 
                cki.Key, cki.KeyChar, cki.Modifiers);
            Console.WriteLine("Hello World! console");

        }
    }
}
