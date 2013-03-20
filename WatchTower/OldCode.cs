using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    class OldCode
    {
        /*
        public enum MediaType { Movie, Episode };

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

        class EpisodeItem : MediaItem
        {
            public string SeriesName = "";
            public int SeasonNum = 0;
            public int EpisodeNum = 0;
            public string EpisodeName = "";
        }

        class MovieItem : MediaItem
        {
            //
        }

        //depricated
        public void LoadMediaFromFolder(string AMovieFolder, string AEspFolder,
            ref List<MediaItem> AMovieList, ref List<EpisodeItem> AEpsList, ref List<MediaItem> ACompleteList)
        {
            AMovieList = new List<MediaItem>();
            AEpsList = new List<EpisodeItem>();
            ACompleteList = new List<MediaItem>();

            //init
            string[] subdirEntries;

            //movies
            string sourceDir = AMovieFolder;
            if (Directory.Exists(sourceDir))
            {
                subdirEntries = Directory.GetDirectories(sourceDir);
                foreach (string movieFolder in subdirEntries)
                {
                    DirectoryInfo di = new DirectoryInfo(movieFolder);
                    MediaItem Movie = new MediaItem { Name = di.Name, FullPath = di.FullName, Type = MediaType.Movie, DateAdded = di.LastWriteTimeUtc };
                    ACompleteList.Add(Movie);
                    AMovieList.Add(Movie);
                }
            }
            else
            {
                MediaItem Movie = new MediaItem { Name = "Directory not found" };
                AMovieList.Add(Movie);
            }


            //episodes
            string SeriesName = "";
            sourceDir = AEspFolder;
            if (Directory.Exists(sourceDir))
            {
                subdirEntries = Directory.GetDirectories(sourceDir);
                foreach (string seriesFolder in subdirEntries)
                {
                    foreach (string EpisodeFile in Directory.GetFiles(seriesFolder))
                    {
                        FileInfo fi = new FileInfo(EpisodeFile);
                        EpisodeItem EpsItem = new EpisodeItem { Name = fi.Name, FullPath = fi.FullName, Type = MediaType.Episode, DateAdded = fi.LastWriteTimeUtc };
                        MediaItem MItem = new MediaItem();
                        MItem = EpsItem;
                        ACompleteList.Add(MItem);
                        //episode details
                        EpsItem.SeriesName = fi.Directory.Name;
                        string sLastPart = fi.Name.Substring(fi.Name.IndexOf(".S") + 2);
                        EpsItem.SeasonNum = int.Parse(sLastPart.Substring(0, 2));
                        EpsItem.EpisodeNum = int.Parse(sLastPart.Substring(3, 2));
                        EpsItem.EpisodeName = sLastPart.Split('.')[1];
                        AEpsList.Add(EpsItem);
                    }
                }
            }
            else
            {
                EpisodeItem EpsItem = new EpisodeItem { SeriesName = "Directory not found" };
                AEpsList.Add(EpsItem);
            }
        } */
    } 
}
