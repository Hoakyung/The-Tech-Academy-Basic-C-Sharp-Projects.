using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing a program that displays the following lines of text
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            // able to write a string variable and assign it the value of the user's input
            string name = Console.ReadLine();
            // able to write a string variable and assign it the value of the user's input
            Console.WriteLine("What course are you on?");
            // able to write a string variable and assign it the value of the user's input
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            // able to write an integer variable and assign it the value of the user's input
            int page_Num = Convert.ToInt32(Console.ReadLine());
            // able to write a string variable and assign it the value of the user's input
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // able to write a boolean variable and assign it the value of the user's input
            string needHelp = Console.ReadLine();
            // able to convert the string variable to a boolean variable
            bool needHelpBool = bool.Parse(needHelp);
            // able to write a string variable and assign it the value of the user's input
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string feedback = Console.ReadLine();
            // able to write a string variable and assign it the value of the user's input
            Console.WriteLine("How many hours did you study today?");
            // able to write an integer variable and assign it the value of the user's input
            string studyHours = Console.ReadLine();
            // able to convert the string variable to an integer variable
            int studyHoursNum = Convert.ToInt32(studyHours);
            // able to write a string variable and assign it the value of the user's input
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            // able to display the following lines of text
            Console.ReadLine();


            
        }
    }
}
