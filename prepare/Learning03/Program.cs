using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(3);
        f1.SetBottom(4);

        f1.GetTop();
        f1.GetBottom();

        // int wholeNumber = f1.GetTop();
        string fractionWritten = f1.GetFractionString();
        Console.WriteLine(fractionWritten);
        double decimalWritten = f1.GetDecimalValue();
        Console.WriteLine(decimalWritten);
    }
}