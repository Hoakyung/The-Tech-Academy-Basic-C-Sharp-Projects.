using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    //Create the Employee class
    class Employee
    {
       //Create the employee's ID, FirstName and LastName properties
       public int Id { get; set; }
       
       public string FirstName { get; set; }
       public string LastName { get; set; }
       // Overload the == operator
       public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
