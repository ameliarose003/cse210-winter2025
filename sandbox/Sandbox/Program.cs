using System;
using System.IO.Compression;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetAge(23);
        p1.SetName("Jerry");

        string theName = p1.GetName();
        Console.WriteLine($"The person's name is {theName}");
    }



}
