using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a C# Application that accepts a user input, then display it in the console application.
            //Let's Begin! :)

            string userInput; //First let us declare a string variable.
            Console.Write("Please input a text: "); //Let us put a message that would prompt for a user input.
            userInput = Console.ReadLine(); //This reads the user input and store it into our declared variable.
            Console.WriteLine("You have inputed a text: " + userInput);

            Console.ReadKey();
            //We forgot to add a User KeyPress, so that the system would wait before exiting.

            //Let us run our system by Pressing F5 or clicking the Start Button above.
            //Let us try again. :)

            //We have done it! :) Happy coding!
        }
    }
}
