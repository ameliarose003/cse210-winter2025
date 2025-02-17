public class Book
{
    string _title;
    string _author;
    string _checkOutData;

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _checkOutData = "";
    }

    public void Display()
    {
        Console.WriteLine("");
    }


}