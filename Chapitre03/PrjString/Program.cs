using System;
using static System.Console;

namespace PrjString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Affichage toString des variables
            int number = 12;
            WriteLine ("number = {0}", number.ToString() );
            bool boolean = true;
            WriteLine("boolean = {0}", boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine("now = {0}", now.ToString());
            object me = new Object();
            WriteLine("me={0}", me.ToString());

            //création d'un objet binaire
            byte[] binaryObject = new byte[128];
            //remplir l'objet avec des bytes aléatoires
            (new Random()).NextBytes(binaryObject);
            WriteLine("Objet binaire : ");

            foreach(byte b in binaryObject)
            {
                Write($"{b:X} ");
            }
            WriteLine();
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Encodage Base 64 : {encoded}");

            //Parse
            int age = int.Parse("23");
            DateTime birthday = DateTime.Parse("01/08/1972");
            WriteLine("Je suis né il y a {0} ans", age);
            WriteLine("Ma date de naissance est {0}", birthday);
            WriteLine("Ma date de naissance est {0:D}", birthday);

            WriteLine("Combien d'oeuf y-a-t-il dans votre sac ?");
            string sNbr = ReadLine();
            int iNbr;

            if (int.TryParse(sNbr,out iNbr))
            {
                WriteLine("Il y a {0} oeufs dans votre sac", iNbr);
            }
            else
            {
                WriteLine("Vous n'avez pas entré un entier");
            }



        }
    }
}
