using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int convertedScore = int.Parse(score);
        string letter;

        if (convertedScore >= 90)
        {
            if (convertedScore % 10 >= 7)
                letter = "A";
            else
            {
                letter = "A-";
            }
        }
        else if (convertedScore >= 80)
        {
            if (convertedScore % 10 >= 7)
                letter = "B+";
            else
            {
                letter = "B-";
            }
        }
        else if (convertedScore >= 70)
        {
            if (convertedScore % 10 >= 7)
                letter = "C+";
            else
            {
                letter = "C-";
            }
        }
        else if (convertedScore >= 60)
        {
            if (convertedScore % 10 >= 7)
                letter = "D+";
            else
            {
                letter = "D-";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is '{letter}'");

        if (convertedScore >= 70)
        {
            Console.WriteLine("Congratulations, you've PASSED!");
        }
        else
        {
            Console.WriteLine("You'll need to try harder next time, as your score falls short of the pass mark!");
        }
    }
}