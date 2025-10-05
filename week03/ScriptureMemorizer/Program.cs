using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures
        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        // Pick a random scripture
        Random rnd = new Random();
        Scripture scripture = library[rnd.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
                break;

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }

        Console.WriteLine("\nAll words are hidden. End of program.");
    }
}
