using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("I Paid A Real Assassin To Try To Kill Me", "MrBeast", 737);
        Video video2 = new Video("I Survived 50 Hours In Antarctica", "MrBeast", 730);
        Video video3 = new Video("Hydraulic Press Vs Lamborghini", "MrBeast", 625);

        Comment comment1 = new Comment("Jakerton", "Mr Beast is slowly turning into a real life James Bond.");
        Comment comment2 = new Comment("mom2mmpt","Imagine all the permits Jimmy would have needed to make all this happen.");
        Comment comment3 = new Comment("caseybowling8999", "Im literally jealous of how much fun you have making a living.");
        Comment comment4 = new Comment("EvanMCGaming", "Respect to the camera man who learned how to fly to get those aerial shots");
        Comment comment5 = new Comment("ailo8625", "Shout out to the camera crew surviving 50 hours in Antarctica while carrying camera equipment!");
        Comment comment6 = new Comment("damienjohnston-peters6478", "Hard to believe I've been watching jimmy for 7 years now. Time flies man");
        Comment comment7 = new Comment("ailo8625", "It is insane how many videos Jimmy is working on at once. The dedication is on another level. Massive respect always!");
        Comment comment8 = new Comment("gamingwithdomi9401", "Jimmy is single handedly the most charitable person in this world. Thank you Jimmy, we love you!");
        Comment comment9 = new Comment("bailey19977", "Props to whoever cleaned all this up afterwards");

        video1.GetCommentList().Add(comment1);
        video1.GetCommentList().Add(comment2);
        video1.GetCommentList().Add(comment3);
        video2.GetCommentList().Add(comment4);
        video2.GetCommentList().Add(comment5);
        video2.GetCommentList().Add(comment6);
        video3.GetCommentList().Add(comment7);
        video3.GetCommentList().Add(comment8);
        video3.GetCommentList().Add(comment9);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            Console.WriteLine("");
            Console.Write("Title: ");
            Console.WriteLine($"{video.GetVideoTitle()}");
            Console.Write("Author: ");
            Console.WriteLine($"{video.GetVideoAuthor()}");
            Console.Write("Video Length (in seconds): ");
            Console.WriteLine($"{video.GetVideoLength()}");
            Console.WriteLine("");
            Console.WriteLine($"Comments: ({video.NumberOfComments()})");
            video.GetComments();
        }

    }
}