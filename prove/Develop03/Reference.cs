public class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startVerse;
        _endVerse = endVerse; 
    }

    public string GetReference()
    {
        string reference;
        if (_endVerse == 0)
        {
            reference = $"{_book} {_chapter}: {_startingVerse}";
        }
        else
        {
           reference = $"{_book} {_chapter}: {_startingVerse} - {_endVerse}"; 
        }
        return reference;
    }


}

