public class Reference
{
    private string _book;
    private int _chapter;
    private int[] _verses;



    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = new int[] {verse};
    }

    public Reference(string book, int chapter, int[] verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }



    public string GetReference()
    {
        bool firstLoop = true;
        int previousVerseNumber = 0;
        string formatedVerseNumbers = "";
        bool stringingNumbers = false;
        foreach (int verseNumber in _verses)
        {
            if (firstLoop)
            {
                firstLoop = false;
                formatedVerseNumbers = verseNumber.ToString();
            }
            else if (previousVerseNumber + 1 == verseNumber)
            {
                stringingNumbers = true;
            }
            else if (stringingNumbers)
            {
                formatedVerseNumbers += $"-{previousVerseNumber}, {verseNumber}";
                stringingNumbers = false;
            }
            else
            {
                formatedVerseNumbers += $", {verseNumber}";
            }
        

            previousVerseNumber = verseNumber;
        }


        if (stringingNumbers)
        {
            formatedVerseNumbers += $"-{previousVerseNumber}";
        }

        return $"{_book} {_chapter}:{formatedVerseNumbers}";
    }
}