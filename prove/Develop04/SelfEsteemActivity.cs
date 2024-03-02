class SelfEsteemActivity : Activity
{
    private int _randomQuestion;

    public SelfEsteemActivity()
    {
        _activityName = "Self-esteem activity";
        _description = "This activity will be an opportunity to see how precious you are. You can increase your self-esteem by sharing love with others.";
    }

    public void Randomprompt(int sec)
    {
        Random randomGenerator = new Random();
        _randomQuestion = randomGenerator.Next(1, 8);

        List<string> questions = new List<string>();
        questions.Add("You are enough just as you are.");
        questions.Add("All our dreams can come true if we have the courage to pursure them.");
        questions.Add("The only way to achieve the impossible is to believe it is possible.");
        questions.Add("Although the world is full of sufferings, it is also full of the overcoming of it.");
        questions.Add("It is only with the heart that one can see right what is essentially invisible to the eye.");
        questions.Add("You can't love someone if you don't love yourself first.");
        questions.Add("Life will knock you down more than you can imagine. So, don't knock yourself down.");
        questions.Add("Act as if what you can make a difference because you can and will.");

        Console.WriteLine("\n\nThink about this message:\n");
        Console.WriteLine(questions[_randomQuestion]);
        Console.Write("\nPress enter if you took enough time to ponder about this.");
        string userInt = Console.ReadLine();
        if (string.IsNullOrEmpty(userInt))
        {
            Console.Clear();
            Console.WriteLine("\nThink about who needs this message the most among your friends or family.");

            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("\nThink about why the person you thought would need this message.");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("\nThink about how to share this message to others");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        Console.WriteLine("\nWhen you have gathered your thoughts, press enter to end this activity.");
        string userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.Clear();
            Console.WriteLine("\nYour care for others brings miracles.");
        }
    }
}