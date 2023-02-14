public class Word
{
    private string _word;
    private Boolean _isShown;



    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }
    
    public Word(string word, Boolean isShown)
    {
        _word = word;
        _isShown = isShown;
    }



    public string GetWord()
    {
        if (_isShown)
        {
            return _word;
        }
        else
        {
            string underscores = _word;
            foreach (char character in underscores)
            {
                string characterString = character.ToString();
                underscores = underscores.Replace(characterString, "_");
            }

            return underscores;
        }


        
    }

    public void ShowWord()
    {
        _isShown = true;
    }

    public void HideWord()
    {
        _isShown = false;
    }
}