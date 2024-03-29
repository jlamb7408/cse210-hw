class Activity
{
    protected string _name;
    protected string _description;
    protected int _points; 
    protected List<Vocab> _vocabWords;
    public Activity(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

        Vocab serendipity = new Vocab("Serendipity", "The occurrence of fortunate events by chance.");
        Vocab mellifluous = new Vocab ("Mellifluous", "Sweet or musical; pleasant to hear");
        Vocab empheral = new Vocab ("Ephemeral", "Lasting for a very short time; transient.");
        Vocab esoteric = new Vocab ("Esoteric", "Intended for or likely to be understood by only a small number of people with a specialized knowledge or interest.");
        Vocab ubiquitous = new Vocab ("Ubiquitous", "Present, appearing, or found everywhere.");
        _vocabWords = new List<Vocab>{serendipity,mellifluous, empheral, esoteric, ubiquitous};
    }
    protected Vocab GetVocabWord()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _vocabWords.Count());
        return _vocabWords[randomNumber];

    }
    public virtual int Run()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
}