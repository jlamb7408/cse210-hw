class Activity
{
    //The parant class has three classes that inherit from it. FlashCard, Matching, and Hangman
    private string _name;
    private string _description;
    private int _points; 
    private List<Vocab> _vocabWords;
    public Activity(string name, string description, int points, List<Vocab> vocabWords)
    {
        _name = name;
        _description = description;
        _points = points;
        _vocabWords = vocabWords;
    }
    public virtual int Run()
    //This class will run what each activity is supposed to do. Since each activity runs differntly, it is virtual.
    {
        return _points;
    }
    public void DisplayActivity()
    //This displays the name and descirption of an activty
    {
        Console.WriteLine(_name + ": " + _description);
    }
    public string GetName()
    //Returns the name of an activity
    {
        return _name;
    }
    public void DisplayWords()
    //Displays the vocab words with their deffitions
    {
        foreach(Vocab w in _vocabWords)
        {
            w.DisplayWordAndDeff();
        }
    }
    protected Vocab GetAVocabWord()
    //returns a random vocab word from the list
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _vocabWords.Count());
        return _vocabWords[randomNumber];

    }
    public List<Vocab> GetAllWords()
    {
        //returns a list of all the words. Since lists are stored as references, I made it return a different list as it will be alted 
        List<Vocab> vocabWords = new List<Vocab>();
        foreach(Vocab word in _vocabWords)
        {
            vocabWords.Add(word);
        }
        return vocabWords;
    }
    public void ChangeWords()
    //The change words method has a menu where the user can decide to add or remove a single word or change the words entirely
    {

        Console.Clear();
        Console.WriteLine("Change Words options:");
        Console.WriteLine(" 1. Add a single word");
        Console.WriteLine(" 2. Remove a singe word");
        Console.WriteLine(" 3. Change the entire set of words. This will clear all saved words and you will add new ones");
        Console.WriteLine("Note: you must need to have at least 5 words");
        Console.WriteLine("Enter your option or push enter to cancle and return to the main menu: ");
        string str_UserChoice = Console.ReadLine();
        int userChoice; 
        Console.Clear();

        if (int.TryParse(str_UserChoice, out userChoice))
        {

            if (userChoice == 1)
            {
                Console.WriteLine("What is the word you would like to add: ");
                string newWord = Console.ReadLine();
                Console.WriteLine("What is this word's deffiniton: ");
                string newDeff = Console.ReadLine();
                _vocabWords.Add(new Vocab(newWord,newDeff));
                Console.Clear();
                Console.WriteLine("The new word has been added\n");

            }
            else if (userChoice == 2 && _vocabWords.Count > 5)
            {
                int i = 0;
                foreach(Vocab word in _vocabWords)
                {
                    Console.WriteLine($"{i+1}. {word.GetWord()}");
                    i++;
                }
                Console.WriteLine("Enter the number of the word would you like to remove: ");
                string str_wordPicked = Console.ReadLine();
                int wordPicked; 
                Console.Clear();

                if (int.TryParse(str_wordPicked, out wordPicked))
                {
                    int wordRemoved = wordPicked - 1;
                    _vocabWords.RemoveAt(wordRemoved);
                    Console.WriteLine("The word was removed\n");
                }
                else
                {
                    Console.WriteLine("Action Canlced\n");
                }
            }
            else if (userChoice == 2 && _vocabWords.Count == 5)
            {
                Console.WriteLine("You cannot have less the 5 words at a time.\n");
            }
            else if (userChoice == 3)
            {
                _vocabWords.Clear();
                for(int i = 0; i < 5; i++)
                {
                    if(i != 0)
                    {
                        Console.WriteLine("The word has been added!");
                    }
                    Console.WriteLine("What is a word you would like to add: ");
                    string newWord = Console.ReadLine();
                    Console.WriteLine("What is this word's deffiniton: ");
                    string newDeff = Console.ReadLine();
                    _vocabWords.Add(new Vocab(newWord,newDeff));
                }
                Console.Clear() ;
                Console.WriteLine("Your new words are: ");
                DisplayWords();
                Console.WriteLine("Push enter to continue: ");
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"Action cancled, returning to menu\n");
        }

    }
}