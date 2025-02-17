class Word
{
    private bool _isHidden;
    // public Word(string text)

    public Word()
    {

    }

    public string Hide(string line)
    {
        string replaceWord = new string('_', line.Length);
        _isHidden = true;
        return replaceWord;

    }


    public bool IsHidden()
    {
        return _isHidden;
    }



}