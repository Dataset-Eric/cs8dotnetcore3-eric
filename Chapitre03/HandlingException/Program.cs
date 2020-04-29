using System;
using static System.Console;

namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Avant le parsing");
            WriteLine("Enrer votre âge");
            String sAge = ReadLine();
            try
            {
                int iAge = int.Parse(sAge);
                Write("Vous avez {0} ans ", iAge);
            }
            catch (FormatException)
            {
                WriteLine("L'âge entré n'est pas dans le bon format");
            }
            catch(OverflowException)
            {
                WriteLine("L'age est trop grand pour un entier");
            }
            catch(Exception ex)
            {
                WriteLine("Type : {0} Message :{1}", ex.GetType(), ex.Message);
            }
            WriteLine("Après le parsing");
        }
    }
}
