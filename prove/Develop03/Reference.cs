public class Reference
{
    private string _book;
    private string _chapterNum;
    private string _verseNum;

    // Constructor to initialize the reference
    public Reference(string book, string chapterNum, string verseNum)
    {
        _book = book;
        _chapterNum = chapterNum;
        _verseNum = verseNum;
    }

    // Method to display the complete formatted reference
    public string DisplayRef()
    {
        return $"{_book} {_chapterNum}:{_verseNum}";
    }

    // Setter for the book
    public void SetBook(string book)
    {
        _book = book;
    }

    // Setter for the chapter number
    public void SetChapterNum(string chapterNum)
    {
        _chapterNum = chapterNum;
    }

    // Setter for the verse number
    public void SetVerseNum(string verseNum)
    {
        _verseNum = verseNum;
    }

    // Getter for the book
    public string GetBook()
    {
        return _book;
    }

    // Getter for the chapter number
    public string GetChapterNum()
    {
        return _chapterNum;
    }

    // Getter for the verse number
    public string GetVerseNum()
    {
        return _verseNum;
    }
}