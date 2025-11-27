using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public override void Run()
    {
        Start();
        int breatheDuration = 4;
        for (int i = 0; i < _duration / breatheDuration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(breatheDuration);
            Console.WriteLine("Breathe out...");
            Countdown(breatheDuration);
        }
        End();
    }
}
