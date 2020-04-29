using System;

namespace Ex3._3
{
    class Program
    {
        //parcourir tous les chiffres de 1 à 100
        //Fizz pour chiffre div par 3
        //Buzz pour chiffre div par 5
        //FizzBuzz pour chiffre div par 3 et par 5
        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 20;
            string message;

            for (int i = min; i < max; i++)
            {
                message = string.Empty;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    message = "FizzBuzz";
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        message = "Fizz";
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            message = "Buzz";
                        }
                        else
                        {
                            message = string.Empty;
                        }
                    }
                }
                Console.WriteLine($"i = {i} {message}");
            }
        }
    }
}
