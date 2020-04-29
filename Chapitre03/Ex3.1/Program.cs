using System;

namespace Ex3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            try
            {
                //double rep = i / 0;
                double d = 3.445;
                double rep2 = d / 0;
                //Console.WriteLine($"100/0= {rep}");
                Console.WriteLine($"100/0= {rep2}");
                
                int x=1; 
                int y=1;
                x = ++y;
                Console.WriteLine($"x={x} y={y} ");
                y = 1;
                x = y++;
                Console.WriteLine($"x={x} y={y} ");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attention division par 0");
            }
        }
    }
}
