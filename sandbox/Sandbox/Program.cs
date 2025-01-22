using System;
using System.IO.Compression;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;
        favoriteMovie._rating = "PG";

        Movie otherMovie = new Movie();
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;
        otherMovie._year = 2009;
        otherMovie._title = "Avatar";

        favoriteMovie.Display();
        otherMovie.Display();
        // Console.WriteLine(favoriteMovie._title);
        // Console.WriteLine();

        // DisplayMovieName(favoriteMovie);
        // DisplayMovieName(otherMovie);
    }

    static void DisplayMovieName(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }

}
