public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = GetWords();
    }
    private List<Word> GetWords()
    {
        List<Word> words = new List<Word>();
        string[] WordsInText = _text.Split(' ');
        foreach(string wordInList in WordsInText)
        {
           Word newWord = new Word(wordInList);
           words.Add(newWord);
        }
        return words;
    }
}