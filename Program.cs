using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write questions to the user to determine if they qualify for car insurance.
            Console.WriteLine("What is your age?");
            // Convert the user input to an integer
            int age = Convert.ToInt32(Console.ReadLine());
            //Ask the user if they have ever had a DUI and convert the response to a boolean value
            Console.WriteLine("Have you ever had a DUI? (yes or no)");
            // Convert the user input to a boolean value
            string duiResponse = Console.ReadLine().ToLower();
            // Check if the response is "yes" or "no"
            bool hasDUI = Console.ReadLine().ToLower() == "yes";
            // Ask the user how many speeding tickets they have and convert the response to an integer
            Console.WriteLine("How many speeding tickets do you have?");
            // Convert the user input to an integer
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            // Determine if the user qualifies for car insurance based on the criteria
            Console.WriteLine("Qualified for insurance? " + (age > 15 && !hasDUI && speedingTickets <= 3));
            // If the user qualifies, print "qualified" to the console
            Console.WriteLine("qualified");
        }
    }
}
