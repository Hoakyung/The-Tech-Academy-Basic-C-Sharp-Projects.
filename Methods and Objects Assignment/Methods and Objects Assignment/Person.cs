using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    //Create a class called Person
    public class Person
    {
        
        //give it the two string properties of FirstName and LastName.
        //set = put/change the value
        //get = read/get the value
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called SayName()
        //that takes no parameters and simply writes
        //the person's full name to the console in the format of: "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }

    }

}
