public class Comment
{
    public string _username;
    public string _commentText;

    public Comment(string name, string text)
    {
        _username = name;
        _commentText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {_username}: {_commentText}");
    }
}