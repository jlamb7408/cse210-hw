using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

        while (true)
        {
            Console.WriteLine("Menu Options ");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflecting Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. quit");

            Console.WriteLine("What is your choice? ");
            string str_user_choice = Console.ReadLine();
            int user_choice = int.Parse(str_user_choice);

            Console.WriteLine("How many second would you like the activity to last? ");
            string str_duration = Console.ReadLine();
            int duration = int.Parse(str_duration);

            if (user_choice == 1)
            {
                BreathingActivity Breathing = new BreathingActivity(duration);
                Breathing.RunActivity();
            }
            else if (user_choice == 2)
            {
                ListingActivity Listing = new ListingActivity(duration);
                Listing.RunActivity();
            }
            else if (user_choice == 3)
            {
                ReflectingActivity Reflecting = new ReflectingActivity(duration);
                Reflecting.RunActivity();
            }
            else if (user_choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option selected. Please pick a number between 1-4 of the following choics.");
            }
        }

    }
}