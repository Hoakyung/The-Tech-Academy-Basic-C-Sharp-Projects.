using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    public class Employee : IQuittable
    {
        // Implement the Quit() method required by the IQuittable interface.
        public void Quit()
        {
            Console.WriteLine(" the employee has quit");
        }
    }
}
