/*
Author: Eze Solomon Nwaka
Purpose: to build a program that help people better memorize a scripture by displaying the full scripture 
         and then hide a few words at atime until the complete scripture is hidden.
    This program also attempts to do the stretch assignment by having the program to load scriptures from a file.

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from file
        string[] lines = File.ReadAllLines("Bible.txt");
        var scriptures = new List<Scripture>();
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string[] referenceParts = parts[0].Split(' ');
            string book = referenceParts[0];
            string[] chapterVerseParts = referenceParts[1].Split(':');
            int chapter = int.Parse(chapterVerseParts[0]);
            string[] verseParts = chapterVerseParts[1].Split('-');
            int startVerse = int.Parse(verseParts[0]);
            int? endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : (int?)null;
            Reference reference = endVerse.HasValue ? new Reference(book, chapter, startVerse, endVerse.Value) : new Reference(book, chapter, startVerse);
            Scripture scripture = new Scripture(reference, parts[1]);
            scriptures.Add(scripture);
        }

        // Select a random scripture
        var random = new Random();
        Scripture chosenScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(chosenScripture.GetDisplayText());
            Console.Write("Press the ENTER key to hide words or type 'Quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            chosenScripture.HideRandomWords(5);
            if (chosenScripture.AreAllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(chosenScripture.GetDisplayText());
                break;
            }
        }
    }
}



// class Program
// {
//     static void Main()
//     {
//         Reference reference = new Reference("Jeremiah", 29, 11);
//         Scripture scripture = new Scripture(reference, "For I know the plans I have for you, says the Lord. They are plans for good and not for evil, to give you a future and a hope.");

//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine(scripture.GetDisplayText());

//             Console.Write("Press the ENTER key to hide words or type 'Quit' to exit: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "quit")
//             {
//                 break;
//             }

//             scripture.HideRandomWords(3);

//             if (scripture.AreAllWordsHidden())
//             {
//                 Console.Clear();
//                 Console.WriteLine(scripture.GetDisplayText());
//                 break;
//             }
//         }
//     }
// }


