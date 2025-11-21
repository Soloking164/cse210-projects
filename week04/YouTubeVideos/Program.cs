using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

    
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 240);
        Video video3 = new Video("Video 3", "Author 3", 180);
        Video video4 = new Video("Video 4", "Author 4", 420);

        // Add comments to videos
        video1.AddComment(new Comment("Emeka Chukwunonso", "Incredible video!"));
        video1.AddComment(new Comment("Nathan Akaogu", "Love it!"));
        video1.AddComment(new Comment("Eze Solomon Nwaka", "Nice job!"));

        video2.AddComment(new Comment("Mukhtar Yusuf", "Awesome!"));
        video2.AddComment(new Comment("Adegoke Dele", "Good one!"));
        video2.AddComment(new Comment("Elvis Ebuka", "Well done!"));

        video3.AddComment(new Comment("Maryam Zainab", "Excellent!"));
        video3.AddComment(new Comment("Abubakar Maikudi", "Fantastic!"));
        video3.AddComment(new Comment("Kashim Abba", "Superb!"));

        video4.AddComment(new Comment("Sophia Ediongsenyene", "Wonderful!"));
        video4.AddComment(new Comment("Eya Oliver", "Great effort!"));
        video4.AddComment(new Comment("Eva Okonkwo", "Nice video!"));

        // Create a list of videos
        Video[] videos = new Video[] { video1, video2, video3, video4 };

        // Display videos and comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}