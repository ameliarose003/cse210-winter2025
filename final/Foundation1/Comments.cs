public class Comments
{
    private string _name;
    private string _text;

    public Comments(string name, string comment)
    {
        _name = name;
        _text = comment;
    }

    public string DisplayComment()
    {
        return $"\n @{_name}: '{_text}'";
    }
}