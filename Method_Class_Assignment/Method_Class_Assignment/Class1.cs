using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    //Create a class called MathOperations
    public class MathOperations
    {   
        //Create a void method that takes two integer parameters
        public void Calculate(int number1, int number2)
        {   //Perform a math operation on the first integer

            int result = number1 * 2;
            // Display the result of the math operation
            Console.WriteLine("The result of the math operation is: " + result);
            //Display the second integer to the screen
            Console.WriteLine("The second integer is: " + number2);
        }
    }
    
    
}
