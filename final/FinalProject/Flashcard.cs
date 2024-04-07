class Flashcard: Activity
{
    public Flashcard(List<Vocab> vocabWords): base("FlashCards", "In this activity you will be given a single definition at random and you write the word that goes to that definition. It is worth 20 points", 20, vocabWords){}
    public override int Run()
    {
        Console.Clear();
        Vocab Word = GetAVocabWord();
        Console.WriteLine(Word.GetDefinition());
        Console.WriteLine("Enter the word");
        string userWord = Console.ReadLine().ToLower();

        Console.Clear();
        if (userWord == Word.GetWord().ToLower())
        {
            Console.Write(Word.GetWord());
            Console.Write(" is correct!\n");
            return base.Run();
        }
        else
        {
            Console.Write("That is inccorcet, the corrcet word was ");
            Console.Write(Word.GetWord());
            Console.WriteLine();
            return 0;
        }

    }
}