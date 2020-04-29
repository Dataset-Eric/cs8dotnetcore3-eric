using System;
using static System.Console;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            const Int32 l0 = -10;
            const Int32 l1 = 10;
            const Int32 l2 = 35;
            const Int32 l3 = 35;

            string s;
            s = ligne(l0, l1, l2, l3);
            WriteLine("" + s + "", "TYPE", "TAILLE", "MIN", "MAX");
            WriteLine("" + s + "", "SBYTE", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue) ;
            WriteLine("" + s + "", "SBYTE", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            WriteLine("" + s + "", "BYTE", sizeof(byte), byte.MinValue, byte.MaxValue);
            WriteLine("" + s + "", "SHORT", sizeof(short), short.MinValue, short.MaxValue);
            WriteLine("" + s + "", "USHORT", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            WriteLine("" + s + "", "INT", sizeof(int), int.MinValue, int.MaxValue);
            WriteLine("" + s + "", "UIN", sizeof(uint), uint.MinValue, uint.MaxValue);
            WriteLine("" + s + "", "LONG", sizeof(long), long.MinValue, long.MaxValue);
            WriteLine("" + s + "", "ULONG", sizeof(ulong), ulong.MinValue, long.MaxValue);
            WriteLine("" + s + "", "FLOAT", sizeof(float), float.MinValue, float.MaxValue);
            WriteLine("" + s + "", "DOUBLE", sizeof(double), double.MinValue, double.MaxValue);
            WriteLine("" + s + "", "DECIMAL", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            
        }
        static string ligne1(int i0, int i1, int i2, int i3, string unType, int taille, double min, double max)
        {
            string s = "{0," + i0 + "} {1," + i1 + "} {2," + i2 + "} {3," + i3 + "}," + "\"" + unType + "\"" + "," + taille + "," + min + "," + max;
            return s;
        }
        static string ligne(int i0, int i1, int i2, int i3)
        {
            string s = "{0," + i0 + "} {1," + i1 + "} {2," + i2 + "} {3," + i3 + "}";
            return s;
        }
        static string ligneTitre(int l0, int l1, int l2, int l3, string s0, string s1, string s2, string s3)
        {
            return ""; 
        }
 
    }
}
