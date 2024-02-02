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

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        string _randomPrompt = _prompts[rnd.Next(_prompts.Length)];

        return _randomPrompt;
    }
}

public class QuoteGenerator
{
    public string[] _quotes = new string[]
    {
        "The beautiful thing about learning is that no one can take it away from you. - B. B. King",
        "Don’t let what you cannot do interfere with what you can do. - John Wooden",
        "You don’t have to be great to start, but you have to start to be great. - Zig Ziglar",
        "The expert in anything was once a beginner. - Helen Hayes",
        "I find that the harder I work, the more luck I seem to have. - Thomas Jefferson",
        "Motivation is what gets you started. Habit is what keeps you going. - Jim Ryun",
        "Success is the sum of small efforts, repeated. - R. Collier",
        "The best way to predict your future is to create it. - Abraham Lincoln",
        "You are braver than you believe, stronger than you seem and smarter than you think. - A.A. Milne",
        "He who asks a question is a fool for five minutes; he who does not ask a question remains a fool forever. - Chinese proverb"
    };

    public string GetRandomQuote()
    {
        Random rnd1 = new Random();
        string _randomQuote = _quotes[rnd1.Next(_quotes.Length)];

        return _randomQuote;
    }

}