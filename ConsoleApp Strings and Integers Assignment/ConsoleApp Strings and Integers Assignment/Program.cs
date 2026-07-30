using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers and ask the user to enter a number to divide each integer in the list by.
            // Write a loop that takes each integer in the list and divides it by the number the user entered.
            // Write a try/catch block to handle any errors that may occur, such as dividing by zero or entering text instead of a number.
            try
            {
                List<int> numbers = new List<int> { 2, 4, 8, 18, 36 };

                Console.Write("Please enter a number to divide the integers in the list by: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                // Check if the user input is zero to avoid division by zero
                if (userInput == 0)
                {
                    Console.WriteLine("Please don't divide by zero.");
                }
                // If the user input is not zero, perform the division and display the results
                else
                {// Loop through each integer in the list and divide it by the user input
                    foreach (int number in numbers)
                    {
                        int result = number / userInput;
                        Console.WriteLine($"{number} divided by {userInput} equals {result}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid whole number.");
            }
            //make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
            Console.Write("The program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();

            
        }
       
    }
}
