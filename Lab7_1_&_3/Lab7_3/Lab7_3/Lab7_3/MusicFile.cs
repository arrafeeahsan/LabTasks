﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_3
{
    class MusicFile
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }

        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }


        public MusicFile()
        {

        }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
        }

        public void changeTitle(string title)
        {
            Console.WriteLine("New Title after changing: " + title);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Music Title: " + title);
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Releasing Year : " + yearOfRelease);
            Console.WriteLine("Music duration : " + (durationInSeconds*60) + " seconds");
            Console.WriteLine();
        }
    }
}
