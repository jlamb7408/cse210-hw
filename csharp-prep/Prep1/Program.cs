using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is  your first name? ");
        string first_name = Console.ReadLine();
        
        Console.WriteLine("What is  your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}

/*
What is your first name? Scott
What is your last name? Burton

Your name is Burton, Scott Burton.
*/