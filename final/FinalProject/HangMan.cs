using System.Diagnostics;

class Hangman : Activity
{
    public Hangman(): base("Hangman", "This game is hangman. You are given a random word. You guess leters until you get the word. You can guess 6 wrong letters before you loose. It is worth 50 points", 50){}
    public override int Run()
    {
        int attemptsLeft = 6;
        bool wordGuessed = false;
        Vocab HangManWord = GetVocabWord();
        string hangManWord = HangManWord.GetWord().ToLower();
        char[] guessedWord = new char[hangManWord.Length];
        for (int i = 0; i < hangManWord.Length; i++)
        {
            guessedWord[i] = '_';
        }
        List<char> GuessedLetters = new List<char>();

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Try to guess the word:");

        while (!wordGuessed && attemptsLeft > 0)
        {
            if (attemptsLeft == 6)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine("  	|");
                Console.WriteLine("    	|");
                Console.WriteLine("   	|");
                Console.WriteLine("   	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");
            }
            else if(attemptsLeft == 5)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine(" O	|");
                Console.WriteLine("   	|");
                Console.WriteLine("   	|");
                Console.WriteLine("   	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");
            }
            else if(attemptsLeft == 4)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine(" O	|");
                Console.WriteLine(" | 	|");
                Console.WriteLine(" | 	|");
                Console.WriteLine("   	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");
            }
            else if(attemptsLeft == 3)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine(" O	|");
                Console.WriteLine(" |/	|");
                Console.WriteLine(" | 	|");
                Console.WriteLine("   	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");
            }
            else if(attemptsLeft == 2)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine(" O	|");
                Console.WriteLine("\\|/	|");
                Console.WriteLine(" | 	|");
                Console.WriteLine("   	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");

            }
            else if(attemptsLeft == 1)
            {
                Console.Clear();
                Console.WriteLine(" ________");
                Console.WriteLine(" |	|");
                Console.WriteLine(" O	|");
                Console.WriteLine("\\|/	|");
                Console.WriteLine(" | 	|");
                Console.WriteLine("/  	|");
                Console.WriteLine("        |");
                Console.WriteLine("============");
            }


            Console.WriteLine(guessedWord);
            Console.WriteLine("Incorrect letters guessed:");
            foreach(char c in GuessedLetters)
            {
                Console.Write(c + " ");
            }
    
            Console.WriteLine();
            Console.Write("Enter a letter: ");
            string strLetter = Console.ReadLine().ToLower();
            char letter = char.Parse(strLetter);

            bool letterFound = false;
            for (int i = 0; i < hangManWord.Length; i++)
            {
                if (hangManWord[i] == letter)
                {
                    guessedWord[i] = letter;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                attemptsLeft--;
                GuessedLetters.Add(letter);
                Console.WriteLine("Incorrect guess!");
            }

            if (new string(guessedWord) == hangManWord)
            {
                wordGuessed = true;
            }
        }

        if (wordGuessed)
        {
            Console.WriteLine("Congratulations! You guessed the word: " + hangManWord);
        }
        else
        {
            Console.Clear();
            Console.WriteLine(" ________");
            Console.WriteLine(" |	|");
            Console.WriteLine(" O	|");
            Console.WriteLine("\\|/	|");
            Console.WriteLine(" | 	|");
            Console.WriteLine("/ \\	|");
            Console.WriteLine("        |");
            Console.WriteLine("============");
            Console.WriteLine("Sorry, you ran out of attempts. The word was: " + hangManWord);
        }
        return base.Run();
    }
}