using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run;

            Console.WriteLine("Welcome to the squares & cubes generator!");
            
            run = true;

            while (run)
            {
                Console.Write("Please enter a number:");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Number\t"+"Squared\t"+"Cubed\t");
                Console.WriteLine("========================");

                for (int i = 1; i <= input; i++)
                {
                    Console.WriteLine($"{i} \t {i * i} \t {i * i * i}");
                }

                run = Method.Continue("Would you like to continue? ( y / n)", "y", "n");
            }
            Console.WriteLine("Thanks for using the squares and cubes generator!  Goodbye!");
            Console.ReadLine();


        }
    }
}
