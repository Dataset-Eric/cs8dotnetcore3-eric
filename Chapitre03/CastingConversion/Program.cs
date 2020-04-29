using System;
using static System.Console;
using static System.Convert;

namespace CastingConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            int a = 4;
            int d;
            double b;
            double c = 3.6;
            b = a;
            d =(int) c;

            //ex2
            long e = 10;
            int f = (int)e;
            WriteLine($"e={e:N0} f={f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e={e:N0} f={f:N0}");

            //ex3
            double g = 3.8;
            int h = ToInt32(g);
            WriteLine($" g={g} h={h}");

            double[] doubles = {9.49,9.5,9.51, 10.49,10.5,10.51};
            foreach(double d1 in doubles) { 
                //9.5=10 et 10.5=10 ? banker's rounding alterne l'arrondi vers le haut et vers le bas 
                // pour réduire le biais
                WriteLine($"d1={d1} arrondi={ToInt32(d1)}");
            }
            foreach(double n in doubles)
            {
                WriteLine(
                    format: "Math.Round({0},0, MidPointRounding.AwayFromZero is {1}",
                    arg0:n,
                    arg1:Math.Round(value:n, digits:0, mode:MidpointRounding.AwayFromZero)
                );
            }
        }
    }
}
