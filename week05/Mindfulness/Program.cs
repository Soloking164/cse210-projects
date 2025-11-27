/*
Author: Eze Solomon Nwaka
Purpose: A program that enhances people chances of reflection by proving structure and prompts to guide users through various exercises.
         This program also attempt to solve the stretch assignment by keeping a log of how many times activities were performed.
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
