public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string author, string text) 
    {
        Comment comment = new Comment(author, text);
        _comments.Add(comment);
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds.");
        Console.WriteLine($"Comments: {GetNumberComments()}");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    
    private int GetNumberComments()
    {
        return _comments.Count;
    }
}