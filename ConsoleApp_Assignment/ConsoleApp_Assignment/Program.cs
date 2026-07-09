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
        //    //A boolean comparison using a while statement
        //    Console.Write("Guess my age?");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    bool isGuessed = age == 16;
            
        //         //A switch statement to check the value of age
        //        switch (age)
        //        {
        //            case 16:
        //                Console.WriteLine("You guessed it right!");
        //                isGuessed = true;
        //                break;
        //            case 10:
        //                Console.WriteLine("Too low! Try again.");
        //                age = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 40:
        //                Console.WriteLine("Too high! Try again.");
        //                age = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            //A default case to handle any other values of age
        //            default:
        //                Console.Write("You are wrong! Try again.");
        //                Console.Write("Guess my age?");
        //                age = Convert.ToInt32(Console.ReadLine());
        //                break;

        //        }

        //    //A while statement to repeat the guessing game until the correct age is guessed
        //    while (!isGuessed);

        //    Console.Read();
        //}

        //A boolean comparison using a while statement
        Console.Write("Guess my age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = age == 16;
            //A boolean comparison using a do while statement
            do
            {
                //A switch statement to check the value of age
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
                    //A default case to handle any other values of age
                    default:
                        Console.Write("You are wrong! Try again.");
                        Console.Write("Guess my age?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            //A do while statement to repeat the guessing game until the correct age is guessed
            while (!isGuessed);

            Console.Read();
        }
    }
}
