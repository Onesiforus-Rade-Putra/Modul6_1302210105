// See https://aka.ms/new-console-template for more information
using Modul6_1302210105;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Mahiro");
        SayaTubeVideo video = new SayaTubeVideo("Angel Next Door Season 1");
        video.IncreasePlayCount(1);
        user.addVideo(video);
        SayaTubeVideo video1 = new SayaTubeVideo("Angel Next Door Season 2");
        video1.IncreasePlayCount(2);
        user.addVideo(video1);
        SayaTubeVideo video2 = new SayaTubeVideo("Angel Next Door Season 3");
        video2.IncreasePlayCount(3);
        user.addVideo(video2);
        SayaTubeVideo video3 = new SayaTubeVideo("Angel Next Door Season 4");
        video3.IncreasePlayCount(4);
        user.addVideo(video3);
        SayaTubeVideo video4 = new SayaTubeVideo("Angel Next Door Season 5");
        video4.IncreasePlayCount(5);
        user.addVideo(video4);
        SayaTubeVideo video5 = new SayaTubeVideo("Angel Next Door Season 6");
        video5.IncreasePlayCount(6);
        user.addVideo(video5);
        SayaTubeVideo video6 = new SayaTubeVideo("Angel Next Door Season 7");
        video6.IncreasePlayCount(7);
        user.addVideo(video6);
        SayaTubeVideo video7 = new SayaTubeVideo("Angel Next Door Season 8");
        video7.IncreasePlayCount(8);
        user.addVideo(video7);
        SayaTubeVideo video8 = new SayaTubeVideo("Angel Next Door Season 9");
        video8.IncreasePlayCount(9);
        user.addVideo(video8);
        SayaTubeVideo video9 = new SayaTubeVideo("Angel Next Door Season 10");
        video9.IncreasePlayCount(10);
        user.addVideo(video9);




        user.PrintAllVideoPlaycount();

    }
}


