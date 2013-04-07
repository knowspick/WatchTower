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
       
        private void PoplateList()
        {
            //Movies
            //listViewMovies.ClearObjects();
            //listViewMovies.SetObjects(MovieList);
            //listViewMovies.Sort(ColDate, SortOrder.Descending);

            //Episodes
            listViewEps.ClearObjects();            

            //get list of seiries don't want to watch 
            List<ProfileSeriesRel> UnWantedSeriesRel = new List<ProfileSeriesRel>();
            foreach (CheckBox chk in panelProfiles.Controls)
            {
                if (chk.Checked)                    
                    UnWantedSeriesRel.AddRange(WTEntities.ProfileSeriesRels.Where<ProfileSeriesRel>(
                        ps => ps.ProfileId == (Int64)chk.Tag && ps.WantToWatch == false
                        ).ToList<ProfileSeriesRel>()
                    );
            }
            List<Episode> WantedEpisode = new List<Episode>(AvailableEpisodes);
            foreach (var item in UnWantedSeriesRel)
                WantedEpisode.RemoveAll(e => e.SeriesId == item.SeriesId);

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

        private void FilterMediaByProfile()
        {

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


        private void butShare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sharing Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Episode eps = new Episode(){ 
                SeriesId = 1,
                SeasonNo = 1,
                EpisodeNo = 1,
                Name = "newEps",
                FileFullPath = "",
                DateAddedToCollection = DateTime.Now,
                LastUpdated = DateTime.Now
            };
            WTEntities.Episodes.Add(eps);
            WTEntities.SaveChanges();
            */
            MediaFunctions.UpdateEpisodesFromFolder(WTEntities);

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
            PoplateList();
        }

        private void timerUpdateFiles_Tick(object sender, EventArgs e)
        {
            timerUpdateFiles.Interval = 1800000;
            AvailableEpisodes = MediaFunctions.UpdateEpisodesFromFolder(WTEntities);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Episode eps = listViewEps.SelectedObjects[0] as Episode;
            ProfileSeriesRel psr = WTEntities.ProfileSeriesRels.Where<ProfileSeriesRel>(
                sr => sr.SeriesId == eps.Series.Id &&
                    panelProfiles.Controls.Contains( sr.ProfileId
                );
            if (psr == null)
                WTEntities.ProfileSeriesRels.Add(new ProfileSeriesRel(){ SeriesId = eps.Series.Id
            psr.WantToWatch = false;
        }

    }
}
