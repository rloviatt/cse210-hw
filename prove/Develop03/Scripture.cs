public class Scripture
{
    private List<Word> _words;
    //This list is so that when you pick a word to hide it won't be a word already hidden
    private List<int> _indexes;

    public Scripture()
    {
        _words = new List<Word>();
        _indexes = new List<int>();
    }

    public void SetScriptureText(string text)
    {
        _words.Clear();
        _indexes.Clear();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }

        for (int i = 0; i < _words.Count; i++)
        {
            _indexes.Add(i);
        }
    }

    public void PickWordToHide()
    {
        if (_indexes.Count > 0)
        {
            Random random = new Random();
            int wordsToHide = random.Next(1, 4); // Randomly choose between 1 and 3 words to hide

            for (int i = 0; i < wordsToHide && _indexes.Count > 0; i++)
            {
                int randomIndex = random.Next(_indexes.Count);
                int wordIndex = _indexes[randomIndex];

                // Hide the word at the selected index
                _words[wordIndex].SetWord(_words[wordIndex].HideWord());

                // Remove the index from the list of indexes
                _indexes.RemoveAt(randomIndex);
            }
        }
    }

    public void DisplayScripture(string reference)
    {
        Console.Write(reference + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public List<Word> GetWords()
    {
        return _words;
    }
}
