using System;
using static System.Console;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                WriteLine($"i={i}");
                i++;
            }

            string motDePasse = string.Empty;
            string bonPsw = "P";
            int j = 0;
            do
            {
                Write("Entrer un mot de passe puis ENTER :");
                motDePasse = ReadLine();
                j++;
            } while (!motDePasse.Equals(bonPsw) && j<=10);
            Write("Correct");
        
            for (int y = 0; y < 10; y++)
            {
                WriteLine(y);
            }

            string[] nom = { "Eric", "David", "Olivier" };

            foreach (string n in nom)
            {
                WriteLine(n);
            }

        }
    }
}
