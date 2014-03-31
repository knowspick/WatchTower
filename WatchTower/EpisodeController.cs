﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;

using WatchTower.POCO;

namespace WatchTower
{
    class EpisodeController
    {
        private IDbConnection _DBConn;

        private string[] _EpisodeFiles;
        private List<Profile> _Profiles;

        public EpisodeController(IDbConnection DBConnection)
        {
            _DBConn = DBConnection;
        }

        public void LoadEpisodesInfoFromDrive()
        {
            string sourceDir = Properties.Settings.Default.EpisodePath;
            //iqnore files
            var filteredFiles = Directory
                    .GetFiles(sourceDir, "*", SearchOption.AllDirectories)
                    .Where(file => file.ToLower().Contains("thumbs.db") == false)
                    .ToList();
        }

        public void FilterEpisodesByProfile(List<Profile> Profiles)
        {

        }

        /*
        static public List<Episode> UpdateEpisodesFromFolder(WatchTowerEF WTData)
        {
            List<Entities.Episode> EpsListToDisplay = new List<Entities.Episode>();
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

                    Entities.Series SeriesItem = WTData.Serieses.Where<Entities.Series>
                        (s => s.Name == SeriesName).FirstOrDefault<Entities.Series>();
                    if (SeriesItem == null)
                    {
                        SeriesItem = WTData.Serieses.Add(new Entities.Series
                        {                        
                            Name = SeriesName
                        });
                        WTData.SaveChanges(); //save to get ID from DB                        
                    }

                    //iqnore files
                    var filteredFiles = Directory
                            .GetFiles(seriesFolder)
                            .Where(file => file.ToLower().Contains("thumbs.db") == false)
                            .ToList();

                    foreach (string EpisodeFile in filteredFiles)
                    {                        
                        FileInfo fi = new FileInfo(EpisodeFile);                         
                        //get file details
                        string sLastPart = fi.Name.Substring(fi.Name.IndexOf(".S") + 2);                        
                        int SeasonNo;
                        if (int.TryParse(sLastPart.Substring(0, 2), out SeasonNo))
                            SeasonNo = int.Parse(sLastPart.Substring(0, 2));
                        else
                        {
                            //MessageBox.Show(fi.Name);
                            continue;
                        }
                        int EpisodeNo = int.Parse(sLastPart.Substring(3, 2));
                        string EpisodeName = sLastPart.Split('.')[1];

                        //get or create episode
                        Entities.Episode EpsItem = WTData.Episodes.Where<Entities.Episode>
                            (e => e.SeriesId == SeriesItem.Id 
                                && e.SeasonNo == SeasonNo
                                && e.EpisodeNo == EpisodeNo).FirstOrDefault<Entities.Episode>();
                        if (EpsItem == null)
                            EpsItem = WTData.Episodes.Add(new Episode
                            {
                                SeriesId = SeriesItem.Id,
                                Series = SeriesItem,
                                Name = EpisodeName, 
                                SeasonNo = SeasonNo,
                                EpisodeNo = EpisodeNo,
                                FileFullPath = fi.FullName,
                                DateAddedToCollection = fi.LastWriteTimeUtc 
                            });
                        EpsListToDisplay.Add(EpsItem);
                    }
                }
            }

            WTData.SaveChanges();
            return EpsListToDisplay;
        }
        */

    }
}