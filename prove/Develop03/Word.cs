public class Word
{
    // Attributes.
    string _word;
    Boolean _shown = true;

    // Constructors.
    public Word()
    {
    
    }
    public Word(string word)
    {
        _word = word;
    }

    // Methods.
    public void Display()
    {
        if (_shown)
            Console.Write(_word + " ");
        else
            Console.Write("_" + " ");
    }
    public void Hide()
    {
        _shown = false;
    }
    public string HideWord()
    {
        int wordLength = _word.Length;
        string underscores = new string('_', wordLength);
        return underscores;
    }
}