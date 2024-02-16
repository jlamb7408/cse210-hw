using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference John316 = new Reference("John", 3, 16, 17);
        Scripture John316_S = new Scripture(John316, "I came not to condom the Wordl but to Save it");
        Console.WriteLine("did it work?");
    }
}