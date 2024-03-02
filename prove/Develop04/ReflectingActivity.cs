class ReflectingActivity : Activity
{
    private int _randomNumber;
    private int _randomQuestion;
    private int _num = 0;

    public ReflectingActivity()
    {
        _activityName = "Reflecting activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Randomprompt()
    {
        Random randomGenerator = new Random();
        _randomNumber = randomGenerator.Next(1, 5);

        Console.WriteLine("\nConsider the following prompt:");
        switch (_randomNumber)
        {
            case 1:
                Console.WriteLine(" --- Think of a time when you stood up for someone else. ---");
                break;
            case 2:
                Console.WriteLine(" --- Think of a time when you did something really difficult. ---");
                break;
            case 3:
                Console.WriteLine(" --- Think of a time when you helped someone in need. ---");
                break;
            case 4:
                Console.WriteLine(" --- Think of a time when you did something truly selfless. ---");
                break;
            case 5:
                Console.WriteLine(" --- Who are some of your personal heroes? ---");
                break;
        }

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this expreience.");
        if (string.IsNullOrEmpty(userInput))
        {
            Console.Write("You may begin in: ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        Console.Clear();
    }

    public void Questions(int sec)
    {
        Random randomGenerator = new Random();
        _randomQuestion = randomGenerator.Next(1, 9);

        List<string> question = new List<string>();
        question.Add("Why was this experience meaningful to you?");
        question.Add("Have you ever done anything like this before?");
        question.Add("How did you get started?");
        question.Add("How did you feel when it was complete?");
        question.Add("What made this time different than other times when you were not as successful?");
        question.Add("What is your favorite thing about this experience?");
        question.Add("What could you learn from this experience that applies to other situations?");
        question.Add("What did you learn about yourself through this experience?");
        question.Add("How can you keep this experience in mind in the future?");

        _num = sec / 10;

        while (_num > 0)
        {
            Console.Write(question[_randomQuestion]);
            question.RemoveAt(_randomQuestion);
            Spinner2();
            Console.WriteLine("");
            _num--;
            _randomQuestion = randomGenerator.Next(1, question.Count);
        }
    }
}