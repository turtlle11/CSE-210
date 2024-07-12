using System;

class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        Video video1 = new Video(
        "Linear Equetion",
        "The Organic Chemistry Tutor",
        "11:04"
        );

        Comments video1_comment1 = new Comments("Akira", "YOu'are literally my teacher at this point.");
        video1.Get_Comments().Add(video1_comment1);

        Comments video1_comment2 = new Comments("OxVoid", "This gay helped me to get my Computer science degree");
        video1.Get_Comments().Add(video1_comment2);

        Comments video1_comment3 = new Comments("Physics-on", "In the Era of complexity... This man's simplicity is just killing me.");
        video1.Get_Comments().Add(video1_comment3);

        videos.Add(video1);

        Video video2 = new Video(
        "How do CPUs read machine code?",
        "Ben Eater",
        "49:19"
        );

        Comments video2_comment1 = new Comments("REDPUMPERNICKEL", "This is a very pleasant stroll down memory lane.");
        video2.Get_Comments().Add(video2_comment1);

        Comments video2_comment2 = new Comments("willperston6881", "Your breadboard wiring cleanliness is frustratingly good.");
        video2.Get_Comments().Add(video2_comment2);

        Comments video2_comment3 = new Comments("DC-ox4rc", "Are this videos legal because they are extremely addictive.");
        video2.Get_Comments().Add(video2_comment3);

        videos.Add(video2);



        Video video3 = new Video(
        "TOEFL IBT Complete Test with Answers",
        "TST Prep TOEFL",
        "2:15:14"
        );

        Comments video3_comment1 = new Comments("pa-rp3xx", "Where I can get the answer key?");
        video3.Get_Comments().Add(video3_comment1);

        Comments video3_comment2 = new Comments("frankmd7102", "We do appreciate your sincer contribution to free access to learn and teaching!");
        video3.Get_Comments().Add(video3_comment2);

        Comments video3_comment3 = new Comments("anisnila6115", "Thanks this really helpful for me");
        video3.Get_Comments().Add(video3_comment3);

        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.Display_All();
        }
    }
}