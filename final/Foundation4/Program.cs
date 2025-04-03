using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<ExerciseActivity> _exercises = new List<ExerciseActivity>();
        RunningActivity run1 = new RunningActivity(1.67, 30, "03 Nov 2025");
        _exercises.Add(run1);
        CyclingActivity cycling1 = new CyclingActivity(0.35, 30, "07 Nov 2025");
        _exercises.Add(cycling1);
        SwimmingActivity swimming1 = new SwimmingActivity(15, 60, "15 Nov 2025");
        _exercises.Add(swimming1);

        // Console.WriteLine(run1.DisplaySummary());
        foreach (ExerciseActivity e in _exercises)
        {
            Console.WriteLine(e.DisplaySummary());
        }
    }
}