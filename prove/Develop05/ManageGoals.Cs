class ManageGoals
{
    public void SaveGoals(List<Goals> goals, int points, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);

            foreach (Goals goal in goals)
            {

                string data = goal.GetData();
                outputFile.WriteLine(data);
            }
        }
    }

    public (List<Goals>, int) LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int points = int.Parse(lines[0]);
        List<Goals> goals = new List<Goals>();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] parts2 = parts[1].Split(",");
            string name = parts2[0];
            string desc = parts2[1];
            int points1 = int.Parse(parts2[2]);

            if (goalType == "SimpleGoal")
            {
                bool complete = bool.Parse(parts2[3]);
                var goal = new Simple();
                goal.SetLoad(name, desc, points1, complete);
                goal.GetGoal();
                goal.GetDescription();
                goal.GetPoint();
                goal.GetComplete();
                goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                var goal = new Eternal();
                goal.SetLoad(name, desc, points1);
                goal.GetGoal();
                goal.GetDescription();
                goal.GetPoint();
                goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts2[3]);
                int frequency = int.Parse(parts2[4]);
                int completedNum = int.Parse(parts2[5]);
                var goal = new Checklist();
                goal.SetLoad(name, desc, points1, completedNum, frequency, bonus);
                goal.GetGoal();
                goal.GetDescription();
                goal.GetPoint();
                goal.GetFrequency();
                goal.GetCompletedNum();
                goals.Add(goal);
            }
            else if (goalType == "BadHabit")
            {
                int frequency = int.Parse(parts2[3]);
                int completedNum = int.Parse(parts2[4]);
                var goal = new BadHabit();
                goal.SetLoad(name, desc, points1, completedNum, frequency);
                goal.GetGoal();
                goal.GetDescription();
                goal.GetPoint();
                goal.GetFrequency();
                goal.GetCompletedNum();
                goals.Add(goal);
            }
        }

        return (goals, points);
    }
}