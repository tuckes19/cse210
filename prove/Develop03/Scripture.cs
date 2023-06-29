public class Scripture
{
    // Attributes.
    List<Word> _word = new List<Word>();
    Reference _reference;

    // Constructors.
    public Scripture()
    {

    }

    // Methods.
    public List<Word> GetWordList()
    {
        return _word;
    }
    public void CreateWordFromString(string verse)
    {
        string[] words = verse.Split(' ');
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _word.Add(word);
        }
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(0, _word.Count);
        _word[index].Hide();
    }
}