using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What is something you are grateful for today?",
        "Who did you talk to today, and what did you discuss?",
        "What is something you want to improve tomorrow?",
        "Describe a moment when you felt the Spirit today."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
