using System;

class Program
{
    static void Main(string[] args)
    {
        Vocab happy = new Vocab("Happy", "Feeling or showing pleasure or contentment.");
        Vocab sad = new Vocab ("Sad", "Feeling or showing sorrow; unhappy.");
        Vocab big = new Vocab ("Big", "Of considerable size or extent.");
        Vocab small = new Vocab ("Small", "Of a size that is less than normal or usual.");
        Vocab fast = new Vocab ("Fast", "Moving or able to move quickly.");
        List<Vocab> vocabWords = new List<Vocab>{happy,sad, big, small, fast};

        List<Activity> activities = new List<Activity>{new Flashcard(vocabWords), new Matching(vocabWords), new Hangman(vocabWords)};
        PointTracker openTracker = new PointTracker(); 
        while(true)
        {
            //Main menu and character displays
            openTracker.DisplayCharacter();
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Show Vocab Words and Phrases");
            Console.WriteLine(" 2. Show Activites");
            Console.WriteLine(" 3. Do an Activity");
            Console.WriteLine(" 4. Buy Items");
            Console.WriteLine(" 5. Veiw Inventory");
            Console.WriteLine(" 6. Change Words");
            Console.WriteLine(" 7. Save");
            Console.WriteLine(" 8. Load");
            Console.WriteLine(" 9. quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if(userChoice == "1")   //Show Words selected
            {   
                Console.Clear();
                activities[1].DisplayWords();
                Console.WriteLine();
                Console.WriteLine("Push Enter to return to the menu:");
                Console.ReadLine();
                Console.Clear();
            }
            else if(userChoice == "2")  //Show Activities selected
            {
                Console.Clear();
                foreach(Activity a in activities)
                {
                    a.DisplayActivity();
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Push Enter to return to the menu:");
                Console.ReadLine();
                Console.Clear();
            }
            else if(userChoice == "3")  //Do an Activity selected
            {  
                Console.Clear();
                int i = 1;
                foreach(Activity a in activities)
                {
                    Console.WriteLine(i + ". " + a.GetName());
                    i++;
                }
                
                Console.WriteLine("Enter the number of the activity you would like to do, or push enter to cancle: ");
                string str_UserChoice = Console.ReadLine();
                int userPickedActivity; 
                Console.Clear();

                //This if statement checks to see if an int was entered, if it was not the action is cancled and the user returns to the main menu
                //This both adds a level of stress proffing anf gives the user to option to cancle
                if (int.TryParse(str_UserChoice, out userPickedActivity))
                {
                    if (userPickedActivity == 1)
                    {
                        openTracker.AddPoints(activities[0].Run());
                    }
                    else if (userPickedActivity == 2)
                    {
                        openTracker.AddPoints(activities[1].Run());
                    }
                    else if (userPickedActivity == 3)
                    {
                        openTracker.AddPoints(activities[2].Run());
                    }
                    else
                    {
                        Console.WriteLine("Action Cancled");
                    }
                }
                else
                {
                    Console.WriteLine("Action Canlced\n");
                }
            }
            
            else if(userChoice == "4")  //Buy Items selected
            {
                openTracker.BuyItems();
            }
            else if(userChoice == "5")  //Veiw Inventory selected
            {
                openTracker.VeiwInentory();
            }
            else if(userChoice == "6")  //Add a word Selected.
            {
                activities[1].ChangeWords();
            }
            else if(userChoice == "7")  //Save selected
            {
                openTracker.Save();
            }
            else if(userChoice == "8")  //Load selected
            {
                openTracker.Load();
            }
            else if(userChoice == "9")  //Quit selected
            {
                break;
            }
            else
            {
                Console.WriteLine("That was not a valid option, please pick a number between 1 and 9");
            }
        }
    }
}