using System.Formats.Asn1;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Threading;
public class BreathingActivity : Activity
{
    private const int BREATHE = 4;
    // int HOLDBREATHE = 3;
    public BreathingActivity(string startMsg, string name, string time) : base(startMsg, name, time)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayMessage();
        // Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // Console.Write("How long in seconds would you like to do this breathing activity?");
        string numberString = Console.ReadLine();
        int Duration = 0;
        if (int.TryParse(numberString, out int number))
        {
            Duration = DisplayCountdown(number);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

        int totalDuration = Duration * 1000;
        int breather = 0;
        ShowDotDown();
        Console.WriteLine("Ready!");
        Thread.Sleep(1000);
        Console.WriteLine();
        while (breather < totalDuration)
        {
            Console.Write($"Breathe In ");
            BreatheIn(BREATHE);
            Console.WriteLine();
            Console.Write($"Hold ");
            Animation(BREATHE);
            Console.WriteLine();
            Console.Write("Breathe out ");
            BreatheOut(BREATHE);
            Console.WriteLine();
            Console.Write("Hold ");
            Animation(BREATHE);
            Console.WriteLine();

            breather += BREATHE * 1000 * 4;
        }


    }

    public int DisplayCountdown(int number)
    {
        return number;
    }

    // public void Animation(int durationSeconds)
    // {
    //     int breatheDuration = durationSeconds * 1000;
    //     int delay = 500;

    //     List<string> animatedChar = new List<string> { "^", "<", "v", ">" };

    //     int index = 0;
    //     int elapsed = 0;


    //     while (elapsed < breatheDuration)
    //     {
    //         Console.Write(animatedChar[index]);
    //         Thread.Sleep(delay);
    //         Console.Write("\b");


    //         elapsed += delay;
    //         index = (index + 1) % animatedChar.Count;
    //     }
    // }

}