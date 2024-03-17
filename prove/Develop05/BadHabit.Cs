class BadHabit : Goals
{
    private int _completedNum;
    private int _frequency;

    public override string SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string SetDescription()
    {
        Console.Write("What is a short description of it: ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int SetPoint()
    {
        Console.Write("What is the amount of points associated with this goal(Enter a negative number): ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }

    public int Frequency()
    {
        Console.Write("How many times do you want to repeat: ");
        _frequency = int.Parse(Console.ReadLine());
        return _frequency;
    }

    public int CompletedNum()
    {
        _completedNum++;
        return _completedNum;
    }

    public int GetCompletedNum()
    {
        return _completedNum;
    }

    public override void SetCompleted(bool iscompleted)
    {
        _completedNum++;
        if (_completedNum == _frequency)
        {
            _isCompleted = true;
        }
    }

    public override string GetData()
    {
        return $"Overcome:{_goal},{_description},{_point},{_frequency},{_completedNum}";
    }

    public string GetSentence()
    {
        _sentence = $"-- Currently completed: {_completedNum}/{_frequency}";
        return _sentence;
    }


    public override string SentenceMade()
    {
        return GetSentence();
    }

    public void SetLoad(string goal, string description, int point, int completedNum, int frequency)
    {
        _goal = goal;
        _description = description;
        _point = point;
        _completedNum = completedNum;
        _frequency = frequency;
    }

    public int GetFrequency()
    {
        return _frequency;
    }
}