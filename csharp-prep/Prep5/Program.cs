using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        DisplayResults();

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your username: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please type in your number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Invalid number");
            return 0;
        }
    }

    static int SquareNumber(int integer)
    {
        return integer * integer;
    }

    static void DisplayResults()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNum = SquareNumber(userNumber);

        Console.WriteLine($"Hello, {userName}! The square of your number is {squareNum}");
    }

}