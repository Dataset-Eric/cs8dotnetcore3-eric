using System;
using static System.Console;

namespace PrjReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Entrer votre nom puis Enter : ");
            string nom = ReadLine();
            Write("Entrer votre age : ");
            string age = ReadLine();
            WriteLine($"Bonjour {nom} vous avez {age} ans");
        }
    }
}
