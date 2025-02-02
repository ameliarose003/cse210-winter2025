class Journal
{
    public List<string> _entries = new List<string>();

    public void Display(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}



