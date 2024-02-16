public class Word
{
    private string _fullWord;
    private string _blankWord;
    public Word(string word)
    {
        _fullWord = word;
        _blankWord = CreateBlankWord();
    }

    private string CreateBlankWord()
    {
        int wordLength = _fullWord.Length;
        string blankWord = new string('_', wordLength);
        return blankWord;
    }
}