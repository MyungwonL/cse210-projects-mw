using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqr = SquareNumber(userNumber);

        DisplayResult(userName, sqr);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int sqr = favNum * favNum;
        return sqr;
    }

    static void DisplayResult(string name, int sqr)
    {
        Console.WriteLine($"{name}, the square of your number is {sqr}");
    }



}