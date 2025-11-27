using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long would you like to spend on this activity in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowAnimation(5);
    }

    public void End()
    {
        Console.WriteLine("Great job!");
        ShowAnimation(3);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowAnimation(5);
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r" + new string('.', seconds - i + 1));
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r" + i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
