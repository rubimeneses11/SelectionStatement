using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 11;
            Console.WriteLine("Guess my favorite number.");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput < favoriteNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else if(userInput > favoriteNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

