using System;

namespace modul5_1302200052
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Batman oleh Glen Rio Aristo");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Spiderman oleh Glen Rio Aristo");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Superman oleh Glen Rio Aristo");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film X - man oleh Glen Rio Aristo");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Thor oleh Glen Rio Aristo");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Loki oleh Glen Rio Aristo");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Ironman oleh Glen Rio Aristo");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film One piece oleh Glen Rio Aristo");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Naruto oleh Glen Rio Aristo");
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film  oleh Glen Rio Aristo");

            SayaTubeUser namaUser = new SayaTubeUser("Glen Rio aristo");
            video1.IncreasePlayCount(1);
            video2.IncreasePlayCount(3);
            video3.IncreasePlayCount(5);
            video4.IncreasePlayCount(3);
            video5.IncreasePlayCount(1);
            video6.IncreasePlayCount(2);
            video7.IncreasePlayCount(2);
            video8.IncreasePlayCount(3);
            video9.IncreasePlayCount(5);
           video10.IncreasePlayCount(2);

            namaUser.AddVideo(video1);
            namaUser.AddVideo(video2);
            namaUser.AddVideo(video3);
            namaUser.AddVideo(video4);
            namaUser.AddVideo(video5);
            namaUser.AddVideo(video6);
            namaUser.AddVideo(video7);
            namaUser.AddVideo(video8);
            namaUser.AddVideo(video9);
            namaUser.AddVideo(video10);

            video1.PrintVideoDetails();

            namaUser.PrintAllVideoPlaycount();
        }
    }
}