using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments a1 = new Assignments("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("2.3", "7-3", "Rodriguez Martinez", "Fractions");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssigments a3 = new WritingAssigments("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}