using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Faith and Hope", "Zelalem Eshetu", 320);
        video1.AddComment(new Comment("Natu", "So inspiring!"));
        video1.AddComment(new Comment("Abel", "Loved the message!"));
        video1.AddComment(new Comment("Sara", "Very motivating."));
        videos.Add(video1);

        Video video2 = new Video("C# Basics", "BYU-Idaho", 480);
        video2.AddComment(new Comment("John", "Very helpful tutorial."));
        video2.AddComment(new Comment("Mary", "Great explanation!"));
        video2.AddComment(new Comment("Daniel", "Nice and simple."));
        videos.Add(video2);

        Video video3 = new Video("Pathway Success Stories", "BYU-Pathway", 600);
        video3.AddComment(new Comment("Hanna", "This gave me hope."));
        video3.AddComment(new Comment("Ben", "Amazing stories!"));
        video3.AddComment(new Comment("Ruth", "Thank you for sharing."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
