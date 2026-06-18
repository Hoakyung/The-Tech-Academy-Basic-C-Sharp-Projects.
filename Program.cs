using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pic the number of your choice");
            // Multiply by 50
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 * 50);

            //Add 25
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 + 25);

            //divid by 12.5
            //float num3 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine(num3 / 12.5f);

            //boolean check if greater than 50
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //bool trueOrFalse = num4 > 50;
            //Console.WriteLine(trueOrFalse.ToString());

            //divide by 7 (modulus)
            double num5 = Convert.ToDouble(Console.ReadLine());
            double remainder = num5 % 7;
            Console.WriteLine(remainder);



        }



    }

    
    
}
