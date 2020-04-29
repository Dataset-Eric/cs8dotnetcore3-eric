using System;
using static System.Console;


namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            WriteLine("Nombre d'arguments passés :{0}", args.Length);
            if (args.Length != 4)
            {
                WriteLine("Le nombre d'argument est incorrect");
                WriteLine("Ex: Red Yellow 50 50");
            }
            //WriteLine($"Argument 1 {args[0]}");
            //WriteLine($"Argument 2 {args[1]}");
            foreach (string s in args)
            {
                WriteLine($"Argument {s}");
            }

            width = int.Parse(args[2]);
            height = int.Parse(args[3]);
            
            try
            {
                WriteLine($"Largeur max {LargestWindowWidth}");
                WriteLine($"Hauteur max {LargestWindowHeight}");
                ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0],true);
                BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
                WindowWidth = width;
                WindowHeight = height;
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("La plateforme ne permet pas de gérer les paramètres de la console");
            }
            catch (ArgumentOutOfRangeException)
            {
                WriteLine("La taille de l'écran est incorrect");
                if (width >= LargestWindowWidth)
                {
                    WriteLine($"La largeur {width} est trop grande (param 3 <= {LargestWindowWidth})");
                }
                if (height >= LargestWindowHeight)
                {
                    WriteLine($"La hauteur {height} est trop grande (param 4 <= {LargestWindowHeight}) ");
                }
            }
            catch (ArgumentException)
            {
                WriteLine("La couleur n'existe pas");
            }


        }
    }
}
