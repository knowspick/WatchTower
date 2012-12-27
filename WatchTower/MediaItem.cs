using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WatchTower
{
    public enum MediaType {Movie,Episode};

    class MediaItem
    {
        public string Name;
        public string FullPath;
        public MediaType Type;
        public DateTime DateAdded;

        public int CompareTo(MediaItem b)
        {
            return this.DateAdded.CompareTo(b.DateAdded);
        }
    }


    class MediaFunctions
    {
        public void LoadMediaFromFolder(string AMovieFolder, string AEspFolder,
            ref List<MediaItem> AMovieList, ref List<MediaItem> AEpsList, ref List<MediaItem> ACompleteList)
        {
            AMovieList = new List<MediaItem>();
            AEpsList = new List<MediaItem>();
            ACompleteList = new List<MediaItem>();

            string sourceDir = AMovieFolder;
            string[] subdirEntries = Directory.GetDirectories(sourceDir);
            foreach (string movieFolder in subdirEntries)
            {
                DirectoryInfo di = new DirectoryInfo(movieFolder);
                MediaItem Movie = new MediaItem { Name = di.Name, FullPath = di.FullName, Type = MediaType.Movie, DateAdded = di.LastWriteTimeUtc };
                ACompleteList.Add(Movie);
                AMovieList.Add(Movie);
            }

            sourceDir = AEspFolder;
            subdirEntries = Directory.GetDirectories(sourceDir);
            foreach (string seriesFolder in subdirEntries)
                foreach (string sesionFolder in Directory.GetDirectories(seriesFolder))
                    foreach (string EpisodeFile in Directory.GetFiles(sesionFolder))
                    {
                        FileInfo fi = new FileInfo(EpisodeFile);
                        MediaItem Eps = new MediaItem { Name = fi.Name, FullPath = fi.FullName, Type = MediaType.Episode, DateAdded = fi.LastWriteTimeUtc };
                        ACompleteList.Add(Eps);
                        AEpsList.Add(Eps);
                    }
        }
    }
    
}
