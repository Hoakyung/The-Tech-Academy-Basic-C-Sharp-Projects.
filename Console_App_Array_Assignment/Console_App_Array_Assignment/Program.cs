using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
   class Program
    {
        static void Main()
        {
            // Array of strings
            string[] flowerArray = { "Rose", "Tulip", "Lily", "Sunflower", "Daisy" };

            int flowerIndex;

            // Keep asking until the user enters a valid index(Add in a message that displays
            // when the user selects an index that doesn’t exist.
            do
            {
                Console.Write("Choose a flower index from 0 to 4: ");
                flowerIndex = Convert.ToInt32(Console.ReadLine());

                if (flowerIndex < 0 || flowerIndex > 4)
                {
                    Console.WriteLine("Wrong answer. Please choose an index from 0 to 4.");
                }

            } while (flowerIndex < 0 || flowerIndex > 4);

            // Display the flower
            Console.WriteLine("The flower is: " + flowerArray[flowerIndex]);


            // Array of int
            int[] numArray = { 5, 10, 20, 45, 27 };

            int numIndex;

            // Keep asking until the user enters a valid index
            do
            {
                Console.Write("Choose a number index from 0 to 4: ");
                numIndex = Convert.ToInt32(Console.ReadLine());

                if (numIndex < 0 || numIndex > 4)
                {
                    Console.WriteLine("Wrong answer. Please choose an index from 0 to 4.");
                }

            } while (numIndex < 0 || numIndex > 4);

            // Display the number
            Console.WriteLine("The number is: " + numArray[numIndex]);

            // Create a list of strings
            List<string> fruitList = new List<string>() {"Apple","Banana","Orange","Grapes","Mango" };

            // Ask the user to select an index
            Console.Write("Choose a fruit index from 0 to 4: ");
            int fruitIndex = Convert.ToInt32(Console.ReadLine());
            // Display the fruit

            if (fruitIndex > 0 && fruitIndex < 4)
            {
                Console.WriteLine("The fruit is: " + fruitList[fruitIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

            Console.ReadLine();

        }
    }
}
