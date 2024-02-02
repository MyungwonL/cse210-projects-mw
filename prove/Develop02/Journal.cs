using System;
using System.IO;

class Journal {
    public int StartingPrompt()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.Write("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ");
        int _userChoice = int.Parse(Console.ReadLine());

        return _userChoice;
    }

    public string GetFileName()
    {
        Console.WriteLine("What is the name of the file?");
        string _filename = Console.ReadLine();
        return _filename;
    }

    public List<Entry> _entries = new List<Entry>();

    public void LoadJournal(string _filename)
    {
        string[] _lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in _lines)
        {
            string[] parts = line.Split(",");
            string _date = parts[0];
            string _prompt = parts[1];
            string _response = parts[2];
            string _quote = parts[3];

            Entry entry = new Entry();
            entry._entryDate = _date;
            entry._prompt = _prompt;
            entry._response = _response;
            entry._quote = _quote;

            _entries.Add(entry);
        }
    }

    public void SavetoFile(List<Entry> _entries)
    {
        Console.WriteLine("What is the name of the file?");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryDate},{entry._prompt},{entry._response},{entry._quote}");
            }
        }
    }

}