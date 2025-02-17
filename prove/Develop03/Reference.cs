using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // optional constructor
    public Reference(string referenceText)
    {

    }
    // 

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }

    public string GetDisplayContent(Scripture verse)
    {
        return $"{ToString()} {verse.GetDisplayContent()}";
    }

}