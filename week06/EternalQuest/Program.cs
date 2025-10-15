using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Save & Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayGoals();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    SaveGoals();
                    return;
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            goal.Display();
        }
        Console.WriteLine($"Total Score: {score}");
    }

    static void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Enter goal number to record event:");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            score += goals[index].RecordEvent();
            Console.WriteLine($"Event recorded! Total score: {score}");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple/Eternal/Checklist):");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points:");
        int points = int.Parse(Console.ReadLine());

        if (type == "simple")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "eternal")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "checklist")
        {
            Console.WriteLine("Enter target count:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus points:");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(score);
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.SaveString());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            score = int.Parse(sr.ReadLine());
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                if (type == nameof(SimpleGoal))
                    goals.Add(new SimpleGoal(name, desc, points));
                else if (type == nameof(EternalGoal))
                    goals.Add(new EternalGoal(name, desc, points));
                else if (type == nameof(ChecklistGoal))
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
        }
    }
}
