using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string magicNum = Console.ReadLine();
        // int x = int.Parse(magicNum);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.Write("Please enter your number guess: ");
        string guess = Console.ReadLine();
        int y = int.Parse(guess);

        if (y < number)
        {
            Console.WriteLine("Higher");
        }
        else if (y > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it right!");
        }

        do
        {
            Console.Write("Please enter your number guess: ");
            string tryAgain = Console.ReadLine();
            y = int.Parse(tryAgain);

            if (y < number)
            {
                Console.WriteLine("Higher");
            }
            else if (y > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }
        }
        while (y != number);

    }
}