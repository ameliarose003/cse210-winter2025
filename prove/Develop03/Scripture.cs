using System.Data;

class Scripture
{
    private List<string> _words = new List<string>();
    private string _verse;
    private static readonly Random _random = new Random();


    public Scripture(string text)
    {
        _verse = text;
    }

    public string GetDisplayContent()
    {
        return $"{_verse}";
    }

    public string RandomHideWord(Word hide, int count)
    {
        string[] words = _verse.Split(' ');
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!words[i].All(c => c == '_'))
            {
                availableIndexes.Add(i);
            }
        }


        count = Math.Min(count, words.Length);
        // List<int> availableIndexes = Enumerable.Range(0, words.Length).ToList();
        for (int i = 0; i < count; i++)
        {
            int randomIndex = _random.Next(availableIndexes.Count);
            int selectedWord = availableIndexes[randomIndex];

            availableIndexes.RemoveAt(randomIndex);

            words[selectedWord] = hide.Hide(words[selectedWord]);
        }

        _verse = string.Join(" ", words);

        return _verse;

    }

    public bool IsAllHidden()
    {
        string[] words = _verse.Split(' ');
        // Check to see if all words are hidden and replace it with _
        // I used this because it is similar to javascript lambda functions that are embedded. 
        // It made it easier for me to understand because I have been studying a lot of javascript.
        return words.All(word => word.All(c => c == '_'));
    }



    // public void GetRandomWord()
    // {
    //     foreach (string e in _words)
    //     {

    //     }
    // }
}