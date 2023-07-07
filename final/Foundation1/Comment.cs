public class Comment
{
    // Attributes.
    string _commenterName;
    string _commentText;

    // Constructors.
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Methods.
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    
}