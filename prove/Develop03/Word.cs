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
    public void DisplayWord()
    {
        if (_shown)
            Console.Write(_word + " ");
        else
        {
            int wordLength = _word.Length;
            string underscores = new string('_', wordLength);
            Console.Write($"{underscores}" + " ");
        }
    }
    public void Hide()
    {
        _shown = false;
    }
}