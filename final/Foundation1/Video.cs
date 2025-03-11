public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    public List<string> _comments = new List<string>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _duration = length;
        // _comments.Add(comment);
    }



    public int NumberOfComments()
    {
        int number = 0;
        return number;
    }

    public string PublishedComment()
    {
        string result = "";
        foreach (string c in _comments)
        {
            if (!string.IsNullOrEmpty(c))
            {
                result += c;
            }

        }
        return result;
    }
    public string DisplayVideo()
    {
        return $"Title: {_title}, Author: {_author}, Duration: {_duration} \n Comments: {PublishedComment()} ";
    }
}
// 3-4 videos and about 10 comments
// You don't have to make them private