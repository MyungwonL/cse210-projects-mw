using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        int point1 = 0;
        int goalCount = 0;

        List<Goals> goals = new List<Goals>();
        ManageGoals manageGoals = new ManageGoals();

        while (true)
        {
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("  4. Bad Habit Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalchoice = int.Parse(Console.ReadLine());
                if (goalchoice == 1)
                {
                    var simple = new Simple();
                    simple.SetGoal();
                    simple.SetDescription();
                    simple.SetPoint();
                    goals.Add(simple);
                    goalCount++;
                }
                else if (goalchoice == 2)
                {
                    var eternal = new Eternal();
                    eternal.SetGoal();
                    eternal.SetDescription();
                    eternal.SetPoint();
                    goals.Add(eternal);
                    goalCount++;
                }
                else if (goalchoice == 3)
                {
                    var checklist = new Checklist();
                    checklist.SetGoal();
                    checklist.SetDescription();
                    checklist.SetPoint();
                    checklist.Frequency();
                    checklist.Bonus();
                    checklist.GetCompletedNum();
                    checklist.GetSentence();
                    goals.Add(checklist);
                    goalCount++;
                }
                else if (goalchoice == 4)
                {
                    var badHabit = new BadHabit();
                    badHabit.SetGoal();
                    badHabit.SetDescription();
                    badHabit.SetPoint();
                    badHabit.Frequency();
                    badHabit.GetCompletedNum();
                    badHabit.GetSentence();
                    goals.Add(badHabit);
                    goalCount++;
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Goals item = goals[i];
                    string goal = item.GetGoal();
                    string des = item.GetDescription();
                    string complete = item.DisplayGoals();
                    string sentence = item.SentenceMade();
                    Console.WriteLine($"{i + 1}. {complete} {goal} ({des}) {sentence}");
                }
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                manageGoals.SaveGoals(goals, points, filename);
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                (List<Goals> loadedGoals, int loadedPoints) = manageGoals.LoadGoals(filename);
                goals = loadedGoals;
                points = loadedPoints;
            }


            else if (choice == 5)
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Goals item = goals[i];
                    string goal = item.GetGoal();
                    Console.WriteLine($"{i + 1}. {goal}");
                }
                Console.Write("Which goal did you accomplish? ");
                var input = int.Parse(Console.ReadLine());
                var goalToComplete = goals[input - 1];                
                goalToComplete.SetCompleted(true);

                point1 = goalToComplete.GetPoint();
                points += point1;
                Console.WriteLine($"Congratulations! You have earned {point1} points!");
            }
            else if (choice == 6)
            {
                Console.WriteLine($"You have made {goalCount} goals this time.");
                break;
            }
        }
    }
}