using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the PromptGenerator, Entry, Journal classes
        
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");
        
        int userChoice = 0;
        while (userChoice != 5)
        {
            userChoice = journal.StartingPrompt();

            switch (userChoice)
            {
                case 1: // Write
                    PromptGenerator promptGen = new PromptGenerator();
                    string prompt = promptGen.RandomPrompt(); // Generate a random prompt
                    Console.Write($"{prompt}\n> "); 
                    string response = Console.ReadLine(); // Get user entry

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now.ToString();
                    journal._entries.Add(entry);

                    Console.WriteLine();
                    break;
                case 2: // Display
                    Console.WriteLine();

                    foreach (Entry eachEntry in journal._entries)
                    {
                        Console.WriteLine($"{eachEntry._entryDate} - Prompt: {eachEntry._prompt}\n> {eachEntry._response}");
                        Console.WriteLine();
                    }
                    break;
                case 3: // Load
                    string filename = journal.GetFileName(); // Get filename from user
                    journal.LoadJournal(filename); // Load the file if exists
                    Console.WriteLine();
                    break;
                case 4: // Save
                    journal.SavetoFile(journal._entries); // Save to file
                    Console.WriteLine();                    
                    break;
                case 5: // Quit
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5");
                    break;
            }
        }
    }
}