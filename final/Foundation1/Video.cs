public class Video
{
    // Attributes.
    string _videoTitle;
    string _videoAuthor;
    int _videoLength;
    int _numberOfComments = 0;
    List<Comment> _videoComments = new List<Comment>();

    // Constructors.
    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
    }

    // Methods.
    public List<Comment> GetCommentList()
    {
        return _videoComments;
    }
    public void GetComments()
    {
        foreach (Comment comment in _videoComments)
        {
            Console.WriteLine($"    {comment.GetCommenterName()}");
            Console.WriteLine($"    {comment.GetCommentText()}");
            Console.WriteLine("");
        }
    }
    public int NumberOfComments()
    {
        foreach(Comment comment in _videoComments)
        {
            _numberOfComments += 1;
        }
        return _numberOfComments;
    }
    public string GetVideoTitle()
    {
        return _videoTitle;
    }
    public string GetVideoAuthor()
    {
        return _videoAuthor;
    }
    public int GetVideoLength()
    {
        return _videoLength;
    }
}