using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat an Employee object and store it in an Iquittable variable. (Polymoprphism)
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
