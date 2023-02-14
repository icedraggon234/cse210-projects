public class Scripture
{
    private Verse[] _verses;
    private Reference _reference;


    
    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        Verse verse = new Verse(verseText);
        _verses = new Verse[] {verse};
    }

    public Scripture(Reference reference, string[] versesText)
    {
        _reference = reference;
        _verses = new Verse[versesText.Count()];

        for (int i = 0; i < versesText.Count(); i++)
        {
            Verse verse = new Verse(versesText[i]);
            _verses[i] = verse;
        }
    }



    public Verse[] GetVerses()
    {
        return _verses;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}