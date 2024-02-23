using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());

        Math mathA = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathA.GetSummary());
        Console.WriteLine(mathA.GetHomeworkList());
        
        Writing writingA = new Writing("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingA.GetSummary());
        Console.WriteLine(writingA.GetWritingInformation());
    }
}