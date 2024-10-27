using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create the reference
        Reference reference = new Reference("Proverbs", "3", "5-6");

        // Create the scripture object
        Scripture scripture = new Scripture();

        // Set the scripture text
        scripture.SetScriptureText("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // Main loop to occur until user types "quit" or all words hidden
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture(reference.DisplayRef());

            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.PickWordToHide();

            // Check if all words are hidden
            bool allHidden = true;
            foreach (Word word in scripture.GetWords())
            {
                if (!word.GetWord().Contains('_'))
                {
                    allHidden = false;
                    break;
                }
            }

            if (allHidden)
            {
                Console.Clear();
                scripture.DisplayScripture(reference.DisplayRef());
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}
