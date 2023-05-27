using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        string book = "Alma";
        int chapter = 26;
        int startVerse = 26;
        int endVerse = 27;
        Reference scriptureReference = new Reference(book, chapter, startVerse, endVerse);
        scriptureReference.Display();

        Scripture scripture = new Scripture();
        string startVerseText = $"{startVerse} But behold, my beloved brethren, we came into the wilderness" +
        " not with the intent to destroy our brethren, but with the intent that perhaps we " +
        "might save some few of their souls.";
        string endVerseText = $"{endVerse} Now when our hearts were depressed, and we were about to turn" +
        " back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, "+
        "and bear with patience thine afflictions, and I will give unto you success.";
        string scriptureText = $"{startVerseText} {endVerseText}";

        while (running)
        {
            scripture.CreateWordFromString(scriptureText);
            scripture.HideRandomWord();
        
            foreach (Word word in scripture._word)
            {
                word.Display();
            }

            running = false;
        }
    }
}