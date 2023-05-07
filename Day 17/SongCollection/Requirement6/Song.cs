using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement6
{
    
        class Song
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
            public Song(string name, string artist, string songType, double rating, int noOfDownloads, DateTime dateDownloaded)
            {
                Name = name;
                Artist = artist;
                SongType = songType;
                Rating = rating;
                NoOfDownloads = noOfDownloads;
                DateDownloaded = dateDownloaded;

            }
            public override string ToString()
            {
                return string.Format($"Name:{Name}\n Artist:{Artist}\n SongType:{SongType}\n Rating:{_rating}\n NoOfDownloads:{NoOfDownloads}\n datedownloaded:{DateDownloaded}\n");
            }
        


        }
    
}
