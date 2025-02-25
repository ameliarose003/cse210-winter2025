using System;
using System.IO.Compression;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Staff s1 = new Staff("Mary", "Jane", "F");

        Teacher t1 = new Teacher(123, "Mary", "Jane", "F");
        Console.WriteLine(t1.DisplayGreeting());

        Specialist spec1 = new Specialist("Mathmetitian", "John", "Doe", "m");
        Console.WriteLine(spec1.DisplayGreeting());

        Volunteer v1 = new Volunteer("Eliza", "Snow", "f");
        Console.WriteLine(v1.DisplayGreeting());
    }



}
