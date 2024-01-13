using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90) {
            letter = "A";
        }

        else if (grade >= 80) {
            letter = "B";
        }

        else if (grade >= 70) {
            letter = "C";
        }

        else if (grade >= 60) {
            letter = "D";
        }

        else if (grade < 60) {
            letter = "F";
        }

        Console.Write($"Your grade is {letter}. ");

        if (grade >= 70) {
            Console.Write("You passed the class.");
        }

        else {
            Console.Write("You didn't passed the class.");
        }
    }
}