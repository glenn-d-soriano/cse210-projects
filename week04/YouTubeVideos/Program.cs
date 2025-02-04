using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("How to Code in C#", "Glenn Soriano", 300);
        Video video2 = new Video("Learn Data Structures", "Aiath Soriano", 450);
        Video video3 = new Video("Understanding Algorithms", "Aizen Soriano", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Mary", "Great tutorial!"));
        video1.AddComment(new Comment("Efren", "Very informative, thanks!"));
        video1.AddComment(new Comment("Ramir", "I learned a lot from this video."));

        // Add comments to video2
        video2.AddComment(new Comment("Jem", "Nice explanations!"));
        video2.AddComment(new Comment("Henrietta", "I need more examples."));

        // Add comments to video3
        video3.AddComment(new Comment("Leo", "Great content, but a bit long."));
        video3.AddComment(new Comment("Ephraim", "Very useful for my project."));
        video3.AddComment(new Comment("Mike", "Helped me understand the topic better."));
        
        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine(video.ToString());
            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine(); 
        }
    }
}