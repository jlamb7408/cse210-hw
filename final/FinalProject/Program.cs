using System;

class Program
{
    static void Main(string[] args)
    {
        //These are the set vocab words to practice with. They can be change. I chose easy words to make testing the program go faster
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
            //Main menu displays and the character's equpied items displays
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
            //Each vocab word with the deffinition will be displayed, the user will have to hit enter to return the the menu
            {   
                Console.Clear();
                activities[1].DisplayWords();
                Console.WriteLine();
                Console.WriteLine("Push Enter to return to the menu:");
                Console.ReadLine();
                Console.Clear();
            }

            else if(userChoice == "2")  //Show Activities selected
            // All 3 activites with their exaplination and points will be displayed. The user will have to push enter to return to the menu
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
            //The user will pick between flashcars, match, and hangman activites
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
            //The user will be taken to a shop menu where the items in the shop will be dislayed and the user can spend points to get any item
            {
                
                openTracker.BuyItems();
            }
            
            else if(userChoice == "5")  //Veiw Inventory selected
            //The user will be taken to their characters inventory menu. There they can change their name, see their items, and equip different items
            {
                openTracker.VeiwInentory();
            }
            
            else if(userChoice == "6")  //Add a word Selected.
            //The user will be taken to the change words menu. There they can add or remove single words, or create a new set of words all together
            {
                activities[1].ChangeWords();
            }
            
            else if(userChoice == "7")  //Save selected
            //The user can save their character info to a file
            {
                openTracker.Save();
            }

            else if(userChoice == "8")  //Load selected
            //The user can load their character info from a file
            {
                openTracker.Load();
            }
            
            else if(userChoice == "9")  //Quit selected
            //The program ends
            {
                break;
            }
            
            else    // A layer of stress proofing if the user put in a wrong input
            {
                Console.WriteLine("That was not a valid option, please pick a number between 1 and 9");
            }
        }
    }
}