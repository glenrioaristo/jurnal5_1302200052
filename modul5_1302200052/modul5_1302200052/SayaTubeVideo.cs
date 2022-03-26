using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302200052
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;

        }

        public void IncreasePlayCount(int n)
        {
            playCount = playCount + n;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
        public String getTitle()
        {
            return this.title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("playCount    : " + playCount);
        }

    }
}
