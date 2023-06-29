public class Reference
{
    // Attributes.
    string _book;
    int _startVerse;
    int _endVerse;
    int _chapter;
    int _verseCount;

    // Constructors.
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _chapter = chapter;
        _verseCount = 1;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _chapter = chapter;
        _verseCount = 2;
    }

    // Methods.
    public void DisplayReference()
    {
        if (_verseCount == 1)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
    }
}