using System;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        //variables
        private string artist;
        private string label;
        private short released;
        private List<Track> tracks;

        //Properties
        public string Artist
        {
            get
            {
                return artist ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    artist = value;
                }
            }
        }

        public string Label
        {
            get
            {
                return label ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    label = value;
                }
            }
        }

        public short Released
        {
            get
            {
                return released;
            }
            set
            {
                if (value > 0)
                {
                    released = value;
                }
            }
        }

        public List<Track> Tracks
        {
            get
            {
                return tracks;
            }
        }

        //Construtor
        public MusicCD()
        {
            this.tracks = new List<Track>();
        }

       
        public MusicCD(string artist, string title, decimal price, short released)
            : base(title, price)
        {

            this.Artist = artist;
            this.Released = released;
            this.tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            if (track != null)
            {
                tracks.Add(track);
            }
        }

   
        public TimeSpan GetPlayingTime()
        {
            // Using the Aggregate Linq method to adding the playing time of all tracks together
            return tracks.Aggregate(TimeSpan.Zero, (sum, next) => sum.Add(next.Length));
        }

    }
}