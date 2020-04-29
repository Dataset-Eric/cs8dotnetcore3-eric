using System;
using System.Collections.Generic;
using System.Text;

namespace Fonctions
{
    class Class1
    {
        ///<summary>
        ///Permet de calculer l'angle d'attaque d'un projectile
        ///</summary>
        ///<param name="distance">Distance entre l'objectif et vous</param>
        ///<param name="hauteur">Hauteur entre vous et l'objectif</param>
        ///<returns>Formule : (distance*hauteur)/2</returns>
        public static int getTrajectoire(int distance, int hauteur)
        {
            for (int i=0; i < 100; i++){
                Console.WriteLine($"{i}");
            }
            return (distance * hauteur) / 2;
        }
    }
}
