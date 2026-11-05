using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
     class Program
    {
        static void Main(string[] args)
        {
            //Create the first Employee 
            Employee employee1 = new Employee();
            // Assign an I to the first Employee
            employee1.Id = 1;
            // Create the second Employee object
            Employee employee2 = new Employee();
            //Assign an Id to the second Employee
            employee2.Id = 1;
            // Use the overloaded == operator to compare the two Employee objects.
            Console.WriteLine(employee1 == employee2);

        }
    }
}
