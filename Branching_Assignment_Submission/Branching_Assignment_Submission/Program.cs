using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will calculate the shipping cost of a package based on its weight and dimensions.
            int weightLimit = 50;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight: ");
            int weightInput = Convert.ToInt32(Console.ReadLine());
            // Initialize variables for width, height, and length
            int widthInput = 0;
            int heightInput = 0;
            int lengthInput = 0;

            // Check if the weight exceeds the limit
            if (weightInput > weightLimit)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                return;
            }
            // If the weight is within the limit, prompt the user for dimensions
            else
            {
                Console.WriteLine("Please enter the package width: ");
                widthInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                heightInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                lengthInput = Convert.ToInt32(Console.ReadLine());
            }
            // Calculate the total dimensions and check if it exceeds the limit
            int totalDimensions = widthInput + heightInput + lengthInput;
            if  (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // If the total dimensions are within the limit, calculate the shipping quote
            else
            {
                int quote = (widthInput * heightInput * lengthInput * weightInput) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.WriteLine("Thank you!");
            }
        }
    }
}























