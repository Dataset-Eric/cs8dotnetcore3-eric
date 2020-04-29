using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine("Valeur initiale : {0}", x);
                try
                {
                    x++;
                    WriteLine("Valeur après ajout 1 : {0}", x);
                    x++;
                    WriteLine("Valeur après ajout 1 : {0}", x);
                }
                catch (OverflowException)
                {
                    WriteLine("Dépassement de capacité");
                }

               
            }
            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine("Valeur après ajout 1 : {0}", y);
                y--;
                WriteLine("Valeur après ajout 1 : {0}", y);
                y--;
                WriteLine("Valeur après ajout 1 : {0}", y);
            }

        }
    }
}
