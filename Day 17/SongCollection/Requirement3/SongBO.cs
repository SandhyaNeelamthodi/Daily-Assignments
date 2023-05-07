using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class SongBO
    {
        /*public List<Song>FindSong(List<Song>songList,string type)
        {
            List<Song> l = new List<Song>();
            foreach(Song songs in songList)
            {

            }
        }
        public List<Song>FindSong(List<Song>SongList,DateTime DateCreated)
        {

        }
        public List<Song>FindSong(List<Song>SongList,double rating)
        {

        }*/
        public static  List<Song> FindSong(List<Song> songList, string type)

        {

            return songList.Where(song => song.SongType == type).ToList();

        }

        public static List<Song> FindSong(List<Song> SongList, DateTime dateCreated)

        {

            return SongList.Where(song => song.DateDownloaded == dateCreated).ToList();

        }

        public static List<Song> FindSong(List<Song> SongList, double rating)

        {

            return SongList.Where(song => song.Rating == rating).ToList();

        }

    }
}
