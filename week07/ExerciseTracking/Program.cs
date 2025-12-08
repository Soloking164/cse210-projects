using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("26 Dec 2023", 26, 4.8),
            new Cycling("09 Jan 2024", 36, 9.7),
            new Swimming("13 June 2025", 46, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}