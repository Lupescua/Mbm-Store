using System;

namespace MbmStore.Models
{
    //A single track on a MusicCD
    public class Track
    {
        //variables
        private string title;
        private TimeSpan length;
        private string composer;

        //properties
        public string Title
        {
            get
            {
                return title ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    title = value;
                }
            }
        }

        public TimeSpan Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public string Composer
        {
            get
            {
                return composer ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    composer = value;
                }
            }
        }

        //Constructor
        public Track(){}

        public Track(string title, TimeSpan length)
        {
            this.Title = title;
            this.Length = length;
        }
    }
}