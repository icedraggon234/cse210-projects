public class Verse
{
    private Word[] _words;



    public Verse(string verse)
    {
        string[] words = verse.Split();
        _words = new Word[words.Count()];
        for (int i = 0; i < words.Count(); i++)
        {
            Word word = new Word(words[i]);
            _words[i] = word;
        }
    }



    public Word[] GetWords()
    {
        return _words;
    }
}