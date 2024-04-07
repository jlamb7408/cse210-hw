class Matching : Activity
{
    public Matching(List<Vocab> vocabWords): base("Matching", "In this activity you will be given 5 words along with 5 definitions at random. You are to match the words to their definition. It is worth 100 points", 100, vocabWords){}
    public override int Run()
    {   
        Console.Clear();
        bool completed = true;
        List<Vocab> vocabWords = RandomizeVocabList(GetAllWords());
        List<Vocab> NewList = new List<Vocab>();
        for ( int i = 0; i < 5; i++)
        {
            NewList.Add(vocabWords[i]);
        }
        List<Vocab> vocabDeffinitions = RandomizeVocabList(NewList);
        List<char> letters = new List<char>{'a','b','c','d','e'};
    
        for (int i = 0; i < vocabWords.Count; i++)
        {
            int intNumber = i + 1;
            string strNumber = intNumber.ToString();
            string word = vocabWords[i].GetWord();
            Console.WriteLine($"{letters[i]}. {word}   {strNumber.PadLeft(15 - word.Length)}. {vocabDeffinitions[i].GetDefinition()}");
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"What deffinition number goes with word {letters[i]}? ");
            int userAnswer = int.Parse(Console.ReadLine());
            if(vocabDeffinitions[userAnswer-1] == vocabWords[i])
            {
                Console.WriteLine("Correcct!");
            }
            else
            {
                completed = false;
                break;
            }
           
        }
        Console.Clear();
        if (completed)
        {
            Console.WriteLine($"You got them all correct! You will be rewarded 100 points\n");
            return base.Run();
        }
        else
        {
            Console.WriteLine($"Sorry but that was inccorect, you will now be returned to the main menu\n");
            return 0;
        }
        
    }
    private List<Vocab> RandomizeVocabList(List<Vocab> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Vocab value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        return list;
    }
}