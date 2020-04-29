using System;

namespace Ex_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                //boucle infinie car revient à -128 => utilisation de checked
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine($"i={i}");
                }
            }
        }
    }
}
