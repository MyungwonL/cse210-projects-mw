class Eternal : Goals
{
    public override string SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string SetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int SetPoint()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }

    public override void SetCompleted(bool isCompleted)
    {
        _isCompleted = false;
    }

    public override string GetData()
    {
        return $"EternalGoal:{_goal},{_description},{_point}";
    }

    public override void SetLoad(string goal, string description, int point)
    {
        _goal = goal;
        _description = description;
        _point = point;
    }

}