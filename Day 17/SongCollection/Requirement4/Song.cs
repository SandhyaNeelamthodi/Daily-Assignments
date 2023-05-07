using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    
    
        public class Song : IComparable<Song>
        {
            private string _name;
            private string _artist;
            private string _songType;
            private double _rating;
            private int _noOfDownloads;
            private DateTime _dateDownloaded;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Artist
            {
                get { return _artist; }
                set { _artist = value; }
            }
            public string SongType
            {
                get { return _songType; }
                set { _songType = value; }

            }
            public double Rating
            {
                get { return _rating; }
                set { _rating = value; }
            }
            public int NoOfDownloads
            {
                get { return _noOfDownloads; }
                set
                {
                    _noOfDownloads = value;
                }
            }
            public DateTime DateDownloaded
            {
                get { return _dateDownloaded; }
                set
                {
                    _dateDownloaded = value;
                }
            }
            public Song() { }
            public Song(string _name, string _artist, string _songType, double _rating, int _noOfDownloads, DateTime _dateDownloaded)
            {
                Name = _name;
                Artist = _artist;
                SongType = _songType;
                Rating = _rating;
                NoOfDownloads = _noOfDownloads;
                DateDownloaded = _dateDownloaded;

            }
            public override string ToString()
            {
                return string.Format($"Name:{Name}\n Artist:{Artist}\n SongType:{SongType}\n Rating:{_rating}\n NoOfDownloads:{NoOfDownloads}\n datedownloaded:{DateDownloaded}\n");
            }

        int IComparable<Song>.CompareTo(Song other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
    
}
