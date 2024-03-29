using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User3", "bb");
        video2.AddComment("User4", "Thank you for the video!");
        video2.AddComment("User5", "Inspirational");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User6", "Thanks for sharing!");
        video3.AddComment("User7", "This helped me a lot.");
        video3.AddComment("User8", "Looking forward to more videos.");
        video3.AddComment("User9", "Not impressed.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}