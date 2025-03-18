using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(5, "red");
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());

        Circle c = new Circle(7, "blue");
        Console.WriteLine(c.GetColor());
        Console.WriteLine(c.GetArea().ToString("#.##"));

        Rectangle r = new Rectangle(5, 10, "green");
        Console.WriteLine(r.GetColor());
        Console.WriteLine(r.GetArea());
    }
}