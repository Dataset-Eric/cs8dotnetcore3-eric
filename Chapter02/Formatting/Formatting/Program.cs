using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbrPomme = 12;
            int prixPomme = 2;

            Console.WriteLine(
                format: "{0} pommes coûtent {1:C}",
                arg0: nbrPomme,
                arg1: nbrPomme * prixPomme);

            string formated = string.Format(format: "{0} Pommes coûtent {1:C} Euro", arg0: nbrPomme, arg1: prixPomme * nbrPomme);

            Console.WriteLine(formated);

            Console.WriteLine($"{nbrPomme} pommes coûtent {nbrPomme * prixPomme:C}");

            string txtPomme = "Pommes";
            int cptPomme = 45533;
            string txtBanane = "Bananes";
            int cptBanane = 65444;
            Console.WriteLine(format: "{0:-12} {1,10:N0}", arg0:"Fruits", arg1:"Nombre");
            Console.WriteLine(format: "{0:-12} {1,10:N0}", arg0: txtPomme, arg1: cptPomme);
            Console.WriteLine(format: "{0:-12} {1,10:N0}", arg0: txtBanane, arg1: cptBanane);
        }
    }
}
