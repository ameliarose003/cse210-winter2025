class Entry
{
    public DateTime _date { get; set; }
    public string _promptText;
    public string _entryText;

    public string CreateEntry()
    {
        // The journal should include the date, the prompt, and the entry answer.
        string journalEntry = $"{_date} \n{_promptText} \n{_entryText}";
        return journalEntry;

    }
    // The journal should be read from the txt file that was just created
    public void StartTxt(string filename)
    {
        File.WriteAllText(filename, $"{_date} \n{_promptText} \n{_entryText}");

    }
    public void AppendToTxt(string filename)
    {
        string currentContent = File.ReadAllText(filename);
        if (!currentContent.EndsWith(Environment.NewLine))
        {
            File.AppendAllText(filename, Environment.NewLine);
        }
        File.AppendAllText(filename, $"{_date}{Environment.NewLine}{_promptText}{Environment.NewLine}{_entryText}{Environment.NewLine}");


    }
}