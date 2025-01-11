using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your class grade? (In numbers) ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        string letter = x.ToString();

        if (x >= 90)
        {
            letter = "A";
            // Console.WriteLine("Your grade is an A");
        }
        else if (x < 90 && x >= 80)
        {
            letter = "B";
            // Console.WriteLine("Your grade is a B");
        }
        else if (x < 80 && x >= 70)
        {
            letter = "C";
            // Console.WriteLine("Your grade is a C");
        }
        else if (x < 70 && x >= 60)
        {
            letter = "D";
            // Console.WriteLine("Your grade is a D");
        }
        else
        {
            letter = "F";
            // Console.WriteLine("Your grade is an F");
        }

        Console.WriteLine(letter);
        if (x > 70)
        {
            Console.WriteLine("You passed, Congratulation!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time!");
        }
    }
}