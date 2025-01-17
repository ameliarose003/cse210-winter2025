using System;

class Program
{
    static void Main(string[] args)
    {
        // adj = adjective
        string adj = GetAdjective();
        string noun = GetNoun();
        Console.WriteLine($"I looked out the window and saw a {adj} {noun}!");

    }

    static string GetAdjective()
    {
        string userAdj = "";
        List<string> adjectives;
        adjectives = new List<string>();
        do
        {
            Console.Write("Please enter an adjective, enter 'no' to end: ");
            userAdj = Console.ReadLine();
            if (userAdj != "no")
            {
                adjectives.Add(userAdj);
            }
        }
        while (userAdj != "no".ToLower());
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(adjectives.Count);
        string RandomAdj = adjectives[index];
        return RandomAdj;

    }

    static string GetNoun()
    {
        Console.Write("Please enter a noun: ");
        string userNoun = Console.ReadLine();
        return userNoun;
    }
}