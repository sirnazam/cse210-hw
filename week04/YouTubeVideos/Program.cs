
using System;
using System.Collections.Generic;
using Sirnazam;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "Joseph Kelvin", 600);

        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Mary", "This helped me understand C#."));
        video1.AddComment(new Comment("David", "Thanks for sharing!"));

        Video video2 = new Video("Learning Python", "Kelvin Joseph", 450);

        video2.AddComment(new Comment("Peter", "Very informative."));
        video2.AddComment(new Comment("Sarah", "I enjoyed this lesson."));
        video2.AddComment(new Comment("James", "Please make another video!"));

        Video video3 = new Video("Web Development Basics", "Joseph Kelvin", 720);

        video3.AddComment(new Comment("Grace", "Amazing explanation."));
        video3.AddComment(new Comment("Michael", "I learned something new."));
        video3.AddComment(new Comment("Daniel", "Keep up the good work!"));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video._comments)
            {
                comment.DisplayComment();
            }

            Console.WriteLine();
        }
    }
}
