using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new("John", "3", "16");
        Reference reference2 = new("Proverbs", "3", "5", "6");
        Reference[] references = {reference1, reference2 };

        Scripture scripture1 = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture2 = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding;", "in all thy ways acknoledge him, and he shall direct thy paths.");
        Scripture[] scriptures = { scripture1, scripture2 };

        Console.WriteLine("Please select a scripture you would like to memorize:\n1. John 3:16\n2. Proverbs 3:5-6");
        int userChoice = int.Parse(Console.ReadLine()) - 1;

        Console.Clear();
        references[userChoice].GetRenderedRef();
        scriptures[userChoice].ShowScripture();
        Console.WriteLine("");

        bool done = false;
        while (done == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Please press enter to hide a word or type 'quit' to end this program: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                done = true;
            }

            else if (string.IsNullOrEmpty(userInput))
            {
                Console.Clear();
                references[userChoice].GetRenderedRef();
                scriptures[userChoice].Hide();
                scriptures[userChoice].ShowScripture();
                Console.WriteLine();

                if (scriptures[userChoice].AllHidden())
                {
                    break;
                }
            }

            else
            {
                Console.Write("You have entered a wrong input. Please follow the given instruction.");
            }

        }

    }
}