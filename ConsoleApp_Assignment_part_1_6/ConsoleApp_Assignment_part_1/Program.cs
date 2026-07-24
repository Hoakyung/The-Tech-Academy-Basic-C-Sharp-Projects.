using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A one-deminsional array of strings.
            string[] petArray = new string[5] { "Dog", "Bird", "Cat", "Hamster", "Parrot" };
            //Ask the user to input some text.
            Console.WriteLine("Please enter your favorite pet:");
            string userPet = Console.ReadLine();

            // A loop that iterates through each string in the array and adds the user's text input to the end of each string. 

            for (int i = 0; i < petArray.Length; i++)
            {
                Console.WriteLine((petArray[i] + " " + userPet));
            }
            //created a second loop that prints off each string in the array without the user's input appended.
            Console.WriteLine("Here are the pets without your input:");
            foreach (string pet in petArray)
            {
                Console.WriteLine(pet);
            }

            ////Infinite loop
            //int j = 0;

            //while (j < 5)
            //{
            //    Console.WriteLine(j);
            //}

            // Fixed loop added j++ to increment the value of j and prevent an infinite loop.
            int j = 0;

            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            // A loop that uses the < (less than) operator as its condition
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k);
            }

            // A loop that uses the <= (less than or equal to) operator as its condition
            int l = 0;
            while (l <= 5)
            {
                Console.WriteLine(l);
                l++;
            }

            //A list of strings where each item in the list is unique.
            List<string> fruits = new List<string>() { "Banna", "Orange", "Kiwi", "Cherry", "Mango" };

            // Ask the user to input text to search for
            Console.WriteLine("Please enter a fruit name to search for:");
            //Get the user's input and convert it to lowercase for case-insensitive comparison
            string userInput = Console.ReadLine().ToLower();

            // Loop through the list and find the matching item
            for (int m = 0; m < fruits.Count; m++)
            {
                if (fruits[m].ToLower() == userInput)
                {
                    Console.WriteLine("The index of the matching fruit is: " + m);
                    // Stops the loop once a match is found
                    break;
                }

            }

            // Check if the fruit exists
            bool found = false;
            // Loop through the list and check if the user's input matches any item in the list
            foreach (string fruit in fruits)
            {
                if (fruit.ToLower() == userInput)
                {
                    found = true;
                }
            }

            if (found == true)
            {
                Console.WriteLine("The fruit is on the list: " + userInput);
            }
            else
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // A list of strings with at least two identical strings
            List<string> name = new List<string>()
            {
                "John",
                "Jane",
                "John",
                "Mary",
                "Jane"
            };

            // Ask the user to select text to search for
            Console.WriteLine("Please enter a name of person to search for:");
            string nameInput = Console.ReadLine();

            // A loop that iterates through the list and displays the index of the matching item
            bool nameFound = false;

            // Loop through the list and display all matching indexes
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToLower() == nameInput.ToLower())
                {
                    Console.WriteLine("The index of the matching name is: " + i);
                    // add this to true to indicate that a match was found
                    nameFound = true;
                }
            }

            if (nameFound == false)
            {
                Console.WriteLine("The name is not on the list.");
            }


            // A list of strings with at least two identical strings
            List<string> nameList = new List<string>()
            {
                "England",
                "Korea",
                "America",
                "Mexico",
                "Japan",
                "America",
                "Mexico"
            };
            // A loop that iterates through the list and displays a message indicating whether or not each item has already appeared in the list.
            List<string> duplicatedCountries = new List<string>();
            // Loop through the list and check for duplicates
            foreach (string country in nameList)
            {
                if (duplicatedCountries.Contains(country))
                {
                    Console.WriteLine(country + " is duplicated.");
                }
                else
                {
                    Console.WriteLine(country + " is unique.");
                    duplicatedCountries.Add(country);
                }
            }

        }
    }
}
