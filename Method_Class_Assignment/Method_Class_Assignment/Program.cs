using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();
            // Call the Calculate method and pass in two numbers
            // number1 receives 8 and number2 receives 3
            math.Calculate(8, 3);
            // Call the Calculate method and pass in two numbers
            // number1 receives 30 and number2 receives 6
            math.Calculate(number1:30, number2: 6);
        }
    }
}
