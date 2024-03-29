class Vocab
{
    private string _word;
    private string _definition;
    public Vocab(string word, string definition)
    {
        _word = word;
        _definition = definition;
    }
    public string GetWord()
    {
        return _word;
    }
    public string GetDefinition()
    {
        return _definition;
    }
    public void DisplayWordAndDeff()
    {
        Console.WriteLine(_word + ": " + _definition);
    }
}