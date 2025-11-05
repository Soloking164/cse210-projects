/*
    Purpose: This program creates a journal app that gives people a simple prompt to respond to every day, 
            thereby saving their time and ensuring that they don't miss documenting their daily experiences.
            This program also attempts the stretch activities by adding and saving other information in the journal entry
    Author: Eze Solomon Nwaka    
   
*/

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of my journal
        Journal journal = new Journal();

       
        bool running = true;
        while (running)
        {
            Console.WriteLine($"🔥 Current Journaling Streak: {journal.GetStreak()} day(s) in a row!\n");
            Console.WriteLine("Welcome to the Journal App!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save to (e.g., journal.txt): ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load (e.g., journal.txt): ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                journal.DisplayEntries(); // Optional: Immediately show what was loaded
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }

            Console.WriteLine(); // add spacing
        }
    }
}