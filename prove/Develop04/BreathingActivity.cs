class BreathingActivity : Activity
{
    private int _breathIn;
    private int _breathOut;

    public BreathingActivity()
    {
        _activityName = "Breathing activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //breath in 4 sec, breath out 6 sec.
    public void BreathTime(int sec)
    {
        _breathIn = 4;
        _breathOut = 6;
        while (sec > 0)
        {
            Console.Write("\n\nBreath in ...");
            for (int i = _breathIn; i > 0; i--)
            {
                sec--;
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

            Console.Write("\nNow breath out...");
            for (int i = _breathOut; i > 0; i--)
            {
                sec--;
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        Console.WriteLine();
    }
}