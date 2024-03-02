class Activity
{
    protected string _activityName = "";

    protected string _description = "";

    protected string _duration{get; set;}

    //make a number for count time.
    private int _countTime;

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n");
    }

    public void DescriptionMessage()
    {
        Console.WriteLine($"{_description}\n");
    }

    public int CountDown()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string sec = Console.ReadLine();
        _countTime = int.Parse(sec);   

        return _countTime;     
    }


    public void EndingMessage(int sec)
    {
        Console.WriteLine("\nWell done!!");
        Spinner();
        Console.WriteLine($"\nYou have completed {sec} seconds of the {_activityName}");
        Spinner();
    }

    public void Spinner()
    {
        List<string> _animationStrings = new List<string>();
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");

        foreach(string s in _animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void Spinner2()
    {
        List<string> _animationStrings = new List<string>();
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string a = _animationStrings[i]; 
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if(i>=_animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}