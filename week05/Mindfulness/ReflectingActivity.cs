using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on this prompt: {prompt}");

        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0) return "No prompts available.";
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        if (_questions.Count == 0) return "No questions available.";
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayQuestions()
    {
        foreach (var q in _questions)
        {
            Console.WriteLine(q);
            Console.Write("> ");
            string answer = Console.ReadLine();
        }
    }
}
