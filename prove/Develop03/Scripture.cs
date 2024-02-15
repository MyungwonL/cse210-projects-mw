public class Scripture
{
    private string _scripture;
    private string _scripture2;
    private List<Word> words = new();

    public Scripture(string scripture)
    {
        _scripture = scripture;
        string[] splitWords = _scripture.Split(" ");

        foreach (string aWord in splitWords)
        {
            Word word = new(aWord);
            words.Add(word);
        }
    }

    public Scripture(string scripture, string scripture2)
    {
        _scripture = scripture;
        _scripture2 = scripture2;
        string[] splitWords = _scripture.Split(" ");
        string[] splitWords2 = _scripture2.Split(" ");
        
        foreach (string aWord in splitWords)
        {
            Word word = new(aWord);
            words.Add(word);
        }
        
        foreach (string aWord in splitWords2)
        {
            Word word = new(aWord);
            words.Add(word);
        }
    }


    public void ShowScripture()
    {
        foreach (Word word in words)
        {
            if (word.GetHidden())
            {
                int letterCount = CountLetters(word);
                Console.Write(new string('_', letterCount) + " ");

                // function to count the length of each word
                int CountLetters(Word word)
                {
                    string wordAsString = word.WordToString();
                    return wordAsString.Length;
                }
            }

            else
            {
                Console.Write($"{word.ShowWord()} ");
            }
        }
    }

    public void Hide()
    {
        Random rnd = new();
        int _rndNum = rnd.Next(words.Count);

        while (words[_rndNum].GetHidden())
        {
            _rndNum = rnd.Next(words.Count);
        }

        words[_rndNum].SetHidden();
    }

    public bool AllHidden()
    {
        foreach (Word word in words)
        {
            if (word.GetHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}