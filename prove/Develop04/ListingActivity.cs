class ListingActivity : Activity
{
    private int _randomNumber;
    private int _count = 0;

    public ListingActivity()
    {
        _activityName = "Listing activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Randomprompt()
    {
        Random randomGenerator = new Random();
        _randomNumber = randomGenerator.Next(1, 6);

        Console.WriteLine("List as many responses you can to the foloowing prompt:\n");

        switch (_randomNumber)
        {
            case 1:
                Console.WriteLine(" --- Who are people that you appreciate? ---");
                break;
            case 2:
                Console.WriteLine(" --- What are personal strengths of yours? ---");
                break;
            case 3:
                Console.WriteLine(" --- Who are people that you have helped this week? --- ");
                break;
            case 4:
                Console.WriteLine(" --- When have you felt the Holy Ghost this month? --- ");
                break;
            case 5:
                Console.WriteLine(" --- Who are some of your personal heroes? --- ");
                break;
        }

        Console.Write("\nYou may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void Answer(int sec)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    _count++;
                }
            }
        }
        Console.WriteLine($"You listed {_count} items!");

    }
}