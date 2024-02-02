using System;
using System.IO;

class Journal {
    public int StartingPrompt()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.Write("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }

    public string GetFileName()
    {
        Console.WriteLine("What is the name of the file?");
        string filename = Console.ReadLine();
        return filename;
    }

    public List<Entry> _entries = new List<Entry>();

    public void LoadJournal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry._entryDate = date;
            entry._prompt = prompt;
            entry._response = response;

            _entries.Add(entry);
        }
    }

    public void SavetoFile(List<Entry> _entries)
    {
        Console.WriteLine("What is the name of the file?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryDate},{entry._prompt},{entry._response}");
            }
        }
    }

}