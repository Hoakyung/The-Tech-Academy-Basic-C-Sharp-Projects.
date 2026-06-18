using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main()
        {
            // This program compares the annual salaries of two individuals based on their hourly rates and hours worked per week.
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get input for Person 1
            string name1 = "Person 1";
            Console.WriteLine("Hourly Rate of " + name1 + ":");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly work per week of " + name1 + ":");
            int hoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());

            // Get input for Person 2
            string name2 = "Person 2";
            Console.WriteLine("Hourly Rate of " + name2 + ":");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly work per week of " + name2 + ":");
            int hoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());

            // Calculate and display annual salaries
            Console.WriteLine("Annual salary of " + name1 + ":");
            decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            Console.WriteLine(annualSalary1);

            // Calculate and display annual salaries for Person 2
            Console.WriteLine("Annual salary of " + name2 + ":");
            decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;
            Console.WriteLine(annualSalary2);

            // Compare the annual salaries and display the result
            Console.WriteLine(name1 + " makes more money than " + name2);
            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrFalse);
            








        }
    }

}