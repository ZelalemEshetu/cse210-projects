using System;

public class Prompt
{
    private string[] _prompts = new string[]
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What made you happy today?",
        "What challenged you today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        return _prompts[index];
    }
}
