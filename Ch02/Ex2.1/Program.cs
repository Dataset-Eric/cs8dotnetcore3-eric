using System;

namespace Ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne();
            Book b = new Book();
            Population pop = new Population();
            Univers u = new Univers();
            Employee e = new Employee();

            p.tel ="02/800.10.31";
            p.height = 176;
            p.age = 25;
            p.salary = 3567.34M;
            b.ISBN = "2345-2-3323-3222-5";
            b.price = 23.43M;
            b.weight = .345;
            pop.population = 45543222;
            u.nbrOfStars = double.PositiveInfinity;
            e.number = 50000;
            Console.WriteLine("Hello World!");

        }

    }
    class Personne
    {
        public string tel;
        public ushort height;
        public byte age;
        public decimal salary;
         
    }
    class Book
    {
        public string ISBN;
        public decimal price;
        public double weight;
    }
    class Population
    {
        public Int64 population;
    }
    class Univers
    {
        public double nbrOfStars;
    }
    class Employee
    {
        public ushort number;
    }
}
