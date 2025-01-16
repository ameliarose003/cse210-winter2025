using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int sum = 0;
        int average = 0;
        int? largest = null;
        int? smallest = null;


        int num = -1;
        do
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        while (num != 0);

        Console.WriteLine(numbers.Count + $"numbers were entered.");
        int numCount = numbers.Count;

        foreach (int number in numbers)
        {
            // Console.WriteLine(number);
            sum += number;

            if (largest == null || number > largest)
            {
                largest = number;
            }
            else if (smallest == null || number < smallest && number != 0)
            {
                smallest = number;
            }
            else
            {
                Console.WriteLine("Please input valid numbers or 0 to finish. ");
            }


        }

        Console.WriteLine($"The sum is: " + sum);
        average = sum / (numCount - 1);
        Console.WriteLine($"The average is: " + average);

        if (largest.HasValue && smallest.HasValue)
        {
            Console.WriteLine($"The largest numbers is: " + largest);
            Console.WriteLine($"The smallest numbers is: " + smallest);
        }
        else
        {
            Console.WriteLine("No number was entered");
        }
    }
}