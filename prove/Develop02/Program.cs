using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the PromptGenerator, Entry, Journal classes
        
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");
        
        int _userChoice = 0;
        while (_userChoice != 5)
        {
            _userChoice = journal.StartingPrompt();

            switch (_userChoice)
            {
                case 1: // Write
                    Console.WriteLine();
                    PromptGenerator promptGen = new PromptGenerator();
                    string _prompt = promptGen.GetRandomPrompt(); // Generate a random prompt
                    QuoteGenerator quoteGen = new QuoteGenerator();
                    string _quote = quoteGen.GetRandomQuote(); // Generate a random quote

                    Console.WriteLine($"Motivational quote: '{_quote}'");
                    Console.Write($"{_prompt}\n> "); 
                    string _response = Console.ReadLine(); // Get user entry

                    Entry entry = new Entry();
                    entry._prompt = _prompt;
                    entry._response = _response;
                    entry._entryDate = DateTime.Now.ToString();
                    entry._quote = _quote;
                    journal._entries.Add(entry);

                    Console.WriteLine();
                    break;
                case 2: // Display
                    Console.WriteLine();

                    foreach (Entry eachEntry in journal._entries)
                    {
                        Console.WriteLine($"{eachEntry._entryDate} - Prompt: {eachEntry._prompt}\n> {eachEntry._response}");
                        Console.WriteLine($"Motivational quote: '{eachEntry._quote}'");
                        Console.WriteLine();
                    }
                    break;
                case 3: // Load
                    string _filename = journal.GetFileName(); // Get filename from user
                    journal.LoadJournal(_filename); // Load the file if exists
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