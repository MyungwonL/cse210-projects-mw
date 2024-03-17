class Goals
{
    protected bool _isCompleted;
    protected string _goal;
    protected string _description;
    protected int _point;
    protected string _sentence;
    public virtual string GetData()
    {
        return $"{_point}";
    }

    public bool GetComplete()
    {
        return _isCompleted;
    }

    public virtual string SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public virtual string SetDescription()
    {
        Console.Write("What is a short description of it: ");
        _description = Console.ReadLine();
        return _description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual int SetPoint()
    {
        Console.Write("What is the amount of points associated with this goal: ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }

    public string DisplayGoals()
    {
        if (_isCompleted == true)
        {
            return "[x]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual int GetPoint()
    {
        return _point;
    }

    public virtual void SetCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public virtual string SentenceMade()
    {
        return _sentence;
    }

    public virtual void SetLoad(string goal, string description, int point)
    {
        _goal = goal;
        _description = description;
        _point = point;
    }
}