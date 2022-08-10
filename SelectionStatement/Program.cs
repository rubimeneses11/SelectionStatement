using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What is your favorite school subject?"); //prompting user
            string subject = Console.ReadLine(); //reading user input as a string

            switch (subject) 
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "English":
                    Console.WriteLine("English is my favorite too!");
                    break;
                case "Science":
                    Console.WriteLine("Science is very interesting!");
                    break;
                case "History":
                    Console.WriteLine("History is very fun!");
                    break;
                case "P.E.":
                    Console.WriteLine("You must be very fit!");
                    break;
                default:
                    Console.WriteLine("That's a good one!");
                    break;
            }
        }
    }
}

