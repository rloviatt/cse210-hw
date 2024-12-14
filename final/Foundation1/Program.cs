using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create and add videos to the list
        Video video1 = new Video("Video Title 1", "Author 1", 300);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Loved it!"));
        videos.Add(video1);

        Video video2 = new Video("Video Title 2", "Author 2", 450);
        video2.AddComment(new Comment("User4", "Awesome content!"));
        video2.AddComment(new Comment("User5", "Thanks for sharing."));
        video2.AddComment(new Comment("User6", "Well explained."));
        videos.Add(video2);

        Video video3 = new Video("Video Title 3", "Author 3", 600);
        video3.AddComment(new Comment("User7", "Very helpful."));
        video3.AddComment(new Comment("User8", "I learned a lot."));
        video3.AddComment(new Comment("User9", "Excellent presentation."));
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}