public class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public string HideWord()
    {
        return new string('_', _word.Length);
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
}