using System;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public string[] _prompts = new string[] 
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    public string RandomPrompt()
    {
        Random rnd = new Random();
        string randomPrompt = _prompts[rnd.Next(_prompts.Length)];

        return randomPrompt;
    }
}