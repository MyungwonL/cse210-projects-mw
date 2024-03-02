class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        SelfEsteemActivity selfEsteemActivity = new SelfEsteemActivity();

        do{
            Console.WriteLine("Menu Option: \n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Start self esteeming activity\n  5. Quit\n Select a choice from the menu: ");
            string num = Console.ReadLine();
            number = int.Parse(num);
            Console.Clear();

            //do switch statement for the case 1~4
            switch(number)
            {
                case 1: // breathing
                    breathingActivity.StartingMessage(); 
                    breathingActivity.DescriptionMessage();
                    int sec =  breathingActivity.CountDown();
                    Console.Clear();

                    Console.Write("Get ready...");
                    breathingActivity.Spinner();
                    breathingActivity.BreathTime(sec);
                    breathingActivity.EndingMessage(sec);
                    Console.Clear();
                    break;

                case 2: // reflecting
                    reflectingActivity.StartingMessage();
                    reflectingActivity.DescriptionMessage();
                    int sec2 = reflectingActivity.CountDown();
                    Console.Clear();

                    Console.Write("Get ready...");
                    reflectingActivity.Spinner();
                    reflectingActivity.Randomprompt(); 
                    reflectingActivity.Questions(sec2);
                    reflectingActivity.EndingMessage(sec2);
                    Console.Clear();
                    break;

                case 3: // listing
                    listingActivity.StartingMessage();
                    listingActivity.DescriptionMessage();
                    int sec3 = listingActivity.CountDown();
                    Console.Clear();

                    Console.Write("Get ready...");
                    listingActivity.Spinner();
                    listingActivity.Randomprompt();
                    listingActivity.Answer(sec3);
                    
                    listingActivity.EndingMessage(sec3);
                    Console.Clear();
                    break;

                case 4 :// self esteeming
                    selfEsteemActivity.StartingMessage();
                    selfEsteemActivity.DescriptionMessage();
                    int sec4 = selfEsteemActivity.CountDown();
                    Console.Clear();
                    
                    Console.Write("Get ready...");
                    selfEsteemActivity.Spinner();
                    selfEsteemActivity.Randomprompt(sec4);
                    selfEsteemActivity.EndingMessage(sec4);
                    Console.Clear();
                    break;
            }
        }while(number != 5);
          
    }

}