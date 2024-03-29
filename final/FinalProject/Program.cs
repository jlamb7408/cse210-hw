using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>{new Flashcard(), new Matching(), new Hangman()};
        while(true)
        {
            //Main menu displays
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Show Vocab Words and Phrases");
            Console.WriteLine(" 2. Show Activites");
            Console.WriteLine(" 3. Do an Activity");
            Console.WriteLine(" 4. Buy Items");
            Console.WriteLine(" 5. Veiw Inventory");
            Console.WriteLine(" 6. Add a word");
            Console.WriteLine(" 7. Remove a word");
            Console.WriteLine(" 8. quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if(userChoice == "1")   //Show Words selected
            {   
              
            }
            else if(userChoice == "2")  //Show Activities selected
            {
    
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
                        activities[0].Run();
                    }
                    else if (userPickedActivity == 2)
                    {
                        activities[1].Run();
                    }
                    else if (userPickedActivity == 3)
                    {
                        activities[2].Run();
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
            }
            else if(userChoice == "5")  //Veiw Inventory selected
            {
            }
            else if(userChoice == "6")  //Add a word Selected.
            {
            }
            else if(userChoice == "7")  //Remove a word Selected.
            {
            }
            else if(userChoice == "8")  //Quit selected
            {
                break;
            }
            else
            {

            }
        }
    }
}