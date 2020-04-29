using System;
using static System.Console;

namespace Chapitre03
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = 11;
            int f = 3;
            double g = 11.0;

            WriteLine($"e is {e} f is {f}");
            WriteLine($"e+f = {e+f}");
            WriteLine($"e-f = {e - f}");
            WriteLine($"e*f = {e * f}");
            WriteLine($"e/f = {e / f}");
            WriteLine($"e%f = {e % f}");
            WriteLine($"g is {g:N1} f is {f}");
            WriteLine($"g/f = {g / f}");

            int p = 6;
            p+= 3 ; //p = p + 3
            WriteLine($"p+=3  :{p}");
            p-= 3 ; // p = p - 3
            WriteLine($"p-=3  :{p}");
            p/= 3 ; // p = p / 3
            WriteLine($"p/=3  :{p}");
            p*= 3;  // p = p * 3
            WriteLine($"p*=3  :{p}");

        }
    }
}
