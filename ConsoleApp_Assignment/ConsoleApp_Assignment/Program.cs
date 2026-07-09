using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess my age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = age == 16;

            do
            {
                switch (age)
                {
                    case 16:
                        Console.WriteLine("You guessed it right!");
                        isGuessed = true;
                        break;
                    case 10:
                        Console.WriteLine("Too low! Try again.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("Too high! Try again.");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Write("You are wrong! Try again.");
                        Console.Write("Guess my age?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!isGuessed);

            Console.Read();
        }
    }
}
