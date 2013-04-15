using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BrightIdeasSoftware;
using System.Data.SQLite;
using WatchTower.Entities;

namespace WatchTower
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public WatchTowerEF WTEntities;
        List<Episode> AvailableEpisodes = new List<Episode>();
        List<Profile> SelectedProfiles = new List<Profile>();
       
        private void PoplateList()
        {
            //Movies


            //Episodes                        

            //***** Filter Un WantedSeries *****    
            //the 3 lists we need to popluate
            List<Episode>WantEps = new List<Episode>();
            List<Episode>UnratedEps = new List<Episode>();
            List<Episode>DontWantEps = new List<Episode>();

            //get list accourding to selected profiles
            List<ProfileSeriesRel> WantSeriesRel = new List<ProfileSeriesRel>();
            List<ProfileSeriesRel> UnWantedSeriesRel = new List<ProfileSeriesRel>();
            List<ProfileEpisodeRel> WatchedEpisodeRel = new List<ProfileEpisodeRel>();
            foreach (Profile profile in SelectedProfiles)
            {
                WantSeriesRel.AddRange(WTEntities.ProfileSeriesRels.Where<ProfileSeriesRel>(
                    psr => psr.ProfileId == profile.Id
                        && psr.WantToWatch == true
                    ).ToList<ProfileSeriesRel>()
                );
                UnWantedSeriesRel.AddRange(WTEntities.ProfileSeriesRels.Where<ProfileSeriesRel>(
                    psr => psr.ProfileId == profile.Id
                        && psr.WantToWatch == false
                    ).ToList<ProfileSeriesRel>()
                );
                WatchedEpisodeRel.AddRange(WTEntities.ProfileEpisodeRels.Where<ProfileEpisodeRel>(
                    pes => pes.ProfileID == profile.Id
                        && pes.Watched == true
                    ).ToList<ProfileEpisodeRel>()
                );
            }

            //unrated is everything left
            UnratedEps = new List<Episode>(AvailableEpisodes);
            //fisrt remove al watched episodes
            foreach (var item in WatchedEpisodeRel)
                UnratedEps.RemoveAll(e => e.Id == item.EpisodeId);

            //get wanttowatch list
            foreach (var item in WantSeriesRel)
            {
                WantEps.AddRange(UnratedEps.Where<Episode>(e => e.SeriesId == item.SeriesId));
                UnratedEps.RemoveAll(e => e.SeriesId == item.SeriesId);
            }

            //get don't want to watch list
            foreach (var item in UnWantedSeriesRel)
            {
                DontWantEps.AddRange(UnratedEps.Where<Episode>(e => e.SeriesId == item.SeriesId));
                UnratedEps.RemoveAll(e => e.SeriesId == item.SeriesId);
            }

            //display the 3 list



            listViewEps.ClearObjects();
            listViewEps.SetObjects(WantedEpisode);
            listViewEps.Sort(colEpsDate, SortOrder.Descending);
        }

        public void SetFontSize(int AFontSize)
        {
            Font NewFont = new Font(listViewMovies.Font.Name, AFontSize, listViewMovies.Font.Style, listViewMovies.Font.Unit);
            listViewMovies.Font = NewFont;
            listViewEps.Font = NewFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoplateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WTEntities = new WatchTowerEF();
            System.Data.Entity.Database.SetInitializer<WatchTowerEF>(null);

            SetFontSize(Properties.Settings.Default.FontSize);

            timerUpdateFiles.Interval = 1;
        }

        private void listViewMovies_DoubleClick(object sender, EventArgs e)
        {
            /*
            MediaItem MediaObj = listViewMovies.SelectedObjects[0] as MediaItem;
            string[] files = Directory.GetFiles(MediaObj.FullPath);
            if (files.Length == 2)
            {
                foreach (string FileInMovieFolder in Directory.GetFiles(MediaObj.FullPath))
                {
                    FileInfo fi = new FileInfo(FileInMovieFolder);
                    if (fi.Extension.ToLower() != ".url")
                    {
                        System.Diagnostics.Process.Start(FileInMovieFolder);
                        break;
                    }
                }
            }
            else
                System.Diagnostics.Process.Start(MediaObj.FullPath);
             */
        }

        private void listViewEps_DoubleClick(object sender, EventArgs e)
        {
            /*
            MediaItem MediaObj = listViewEps.SelectedObjects[0] as MediaItem;
            System.Diagnostics.Process.Start(MediaObj.FullPath);
             */
        }


        private void butSettings_Click(object sender, EventArgs e)
        { 
            frmSettings fSettings = new frmSettings(){MainForm = this} ;
            fSettings.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {           
            //set profile button
            List<CheckBox> profilesBut = new List<CheckBox>();
            foreach (Profile profile in WTEntities.Profiles)
            {
                CheckBox chkNew = new CheckBox();
                chkNew.Text = profile.Name;
                chkNew.Appearance = Appearance.Button;
                chkNew.FlatStyle = FlatStyle.Flat;
                chkNew.TextAlign = ContentAlignment.MiddleCenter;
                chkNew.Tag = profile.Id;
                chkNew.Height = panelProfiles.Height - 10;
                chkNew.Left = 5 + chkNew.Left + (panelProfiles.Controls.Count * (chkNew.Width + 5));
                chkNew.CheckedChanged += chkNew_CheckedChanged;
                panelProfiles.Controls.Add(chkNew);
                profilesBut.Add(chkNew);
            }
        }

        void chkNew_CheckedChanged(object sender, EventArgs e)
        {
            SelectedProfiles.Clear();
            foreach (CheckBox chk in panelProfiles.Controls)
            {
                if (chk.Checked)
                    SelectedProfiles.Add(WTEntities.Profiles.SingleOrDefault(pro => pro.Id == (Int64)chk.Tag));
            }
            PoplateList();
        }

        private void timerUpdateFiles_Tick(object sender, EventArgs e)
        {
            timerUpdateFiles.Interval = 1800000;
            AvailableEpisodes = MediaFunctions.UpdateEpisodesFromFolder(WTEntities);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectedProfiles.Clear();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
