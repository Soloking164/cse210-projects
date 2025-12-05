/*
Author: Eze Solomon Nwaka
Purpose: A program that enhances people chances of reflection by proving structure and prompts to guide users through various exercises.
         This program also attempt to solve the stretch assignment by keeping a log of how many times activities were performed.
*/

using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    DisplayScore();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal()
    {
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal = null;

        switch (type)
        {
            case "simple":
                goal = new SimpleGoal(name, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, points);
                break;
            case "checklist":
                Console.Write("Enter target count: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter goal number: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            _goals[goalNumber].RecordEvent();
            _score += _goals[goalNumber].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private static void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()} - {_goals[i].GetStatus()}");
        }
    }

    private static void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    private static void SaveGoals()
    {
        // Implement saving goals to a file
    }

    private static void LoadGoals()
    {
        // Implement loading goals from a file
    }
}