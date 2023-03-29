using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302210105
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.title = title;
            this.playCount = 0;
            this.id = rnd.Next(10000);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }
        
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("video memiliki judul: " + title);
            Console.WriteLine("video memiliki id: " + id);
            Console.WriteLine("video diputar sebanyak: " + playCount);
        }

        public int getplayCount()
        {
            return this.playCount;
        }
        public string getTitle()
        {
            return this.title;
        }

    }

    internal class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideo;
        private string v;

        public SayaTubeUser(string v)
        {
            this.username = username;
            this.uploadedVideo= new List<SayaTubeVideo>();
        }

        public int GetTotalVideoCount()
        {
            int totalVideoCount = 0;
            foreach (SayaTubeVideo item in uploadedVideo)
            {
                totalVideoCount = item.getplayCount() + totalVideoCount;
            }
            return totalVideoCount;

        }

        public void addVideo(SayaTubeVideo video)
        {
           uploadedVideo.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("user :" + username);
            int temp = 0;
            foreach(SayaTubeVideo item in uploadedVideo)
            {
                Console.WriteLine("Review film : " + item.getTitle());
                Console.WriteLine("video ditonton sebanyak : " + item.getplayCount());
                temp++;
            }
        }
    }
}
