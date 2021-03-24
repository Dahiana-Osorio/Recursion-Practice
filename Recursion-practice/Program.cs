using System;

namespace Recursion_practice
{
    class Program
    {
        static void Main (string[] args)
        {
            // Exercise 1
            //Instancia de la clase Totalnumbers
            Totalnumbers miTotalnumbers = new Totalnumbers();
            Console.WriteLine("Enter the number");
            miTotalnumbers.n1 = int.Parse(Console.ReadLine());
            int cont = miTotalnumbers.Totalnumber(miTotalnumbers.n1);
            Console.WriteLine("Total is: " + cont);

            //Exercise 2
            Sumnumbers miSumnumbers = new Sumnumbers();
            Console.WriteLine("Enter the number you want to add your digits");
            miSumnumbers.number = int.Parse(Console.ReadLine());
            int total = miSumnumbers.sumDigitos(miSumnumbers.number);
            Console.WriteLine("Total is: " + total);

            //Exercise 3
            Primenumber miPrimenumber = new Primenumber();
            Console.WriteLine("Enter the number you want to know if it is a prime");
            miPrimenumber.numPrim = int.Parse(Console.ReadLine());

            bool numConsole = miPrimenumber.numPrime(miPrimenumber.numPrim, miPrimenumber.divider);
            if (numConsole == true) {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("Not is prime");
            }

            //exercise 4
            Spiderman miSpaiderman = new Spiderman();
            Console.WriteLine("Enter the building number that Spiderman jumped to: ");
            miSpaiderman.way = int.Parse(Console.ReadLine());
            int res = miSpaiderman.Probableways(miSpaiderman.way);
            Console.WriteLine("Number of ways Spaiderman can jump: " + res);
            Console.ReadKey();
        }
    }
}
