using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WatchTower.Entities;

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

    class MediaFunctions 
    {
        public void UpdateEpisodesFromFolder(WatchTowerEF WTData)
        {                      
            string SeriesName = "";
            string sourceDir = Properties.Settings.Default.EpisodePath;
            string[] subdirEntries;
            if (Directory.Exists(sourceDir))
            {
                subdirEntries = Directory.GetDirectories(sourceDir);
                foreach (string seriesFolder in subdirEntries)
                {
                    //Get or create series
                    SeriesName = new DirectoryInfo(seriesFolder).Name;
                    Series SeriesItem = WTData.Series.Where<Series>
                        (s => s.Name == SeriesName).FirstOrDefault<Series>();
                    if (SeriesItem == null)
                        SeriesItem = WTData.Series.Add(new Series {
                            Name = SeriesName
                        });                   
                    foreach (string EpisodeFile in Directory.GetFiles(seriesFolder))
                    {                        
                        FileInfo fi = new FileInfo(EpisodeFile);                         
                        //get file details
                        string sLastPart = fi.Name.Substring(fi.Name.IndexOf(".S") + 2);
                        int SeasonNo = int.Parse(sLastPart.Substring(0, 2));
                        int EpisodeNo = int.Parse(sLastPart.Substring(3, 2));
                        string EpisodeName = sLastPart.Split('.')[1];

                        //get or create episode
                        Episode EpsItem = WTData.Episodes.Where<Episode>
                            (e => e.SeriesId == SeriesItem.SeriesId 
                                && e.SeasonNo == SeasonNo
                                && e.EpisodeNo == EpisodeNo).FirstOrDefault<Episode>();
                        if (EpsItem == null)
                            EpsItem = WTData.Episodes.Add(new Episode {
                                SeriesId = SeriesItem.SeriesId,
                                Name = EpisodeName, 
                                SeasonNo = SeasonNo,
                                EpisodeNo = EpisodeNo,
                                FileFullPath = fi.FullName,
                                DateAdded = fi.LastWriteTimeUtc 
                            });
                    }
                }
            }
            else
            {
            }
            WTData.SaveChanges();             
        }

        public void UpdateOrphanEpisodes(WatchTowerEF WTData)
        {
            foreach (Episode EpsItem in WTData.Episodes)
                if (EpsItem.FileFullPath != "")
                    if (!File.Exists(EpsItem.FileFullPath))
                        EpsItem.FileFullPath = "";

            WTData.SaveChanges();             
        }

        public List<Episode> GetListOfExstingEpisodes(WatchTowerEF WTData)
        {
            List<Episode> EpsList;
            EpsList = WTData.Episodes.Where(e => e.FileFullPath != "").ToList<Episode>();

            return EpsList;
        }




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
                MediaItem Movie = new MediaItem { Name = "Directory not found"};
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
                EpisodeItem EpsItem = new EpisodeItem {SeriesName = "Directory not found"};
                AEpsList.Add(EpsItem);
            }
        }
    }
    
}
