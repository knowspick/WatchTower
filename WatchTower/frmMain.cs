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
    public partial class WatchTower : Form
    {
        public WatchTower()
        {
            InitializeComponent();
        }

        public WatchTowerEF WTEntities;
       

        List<MediaItem> MediaList = new List<MediaItem>();
        List<MediaItem> MovieList = new List<MediaItem>();
        List<EpisodeItem> EpsList = new List<EpisodeItem>();

        private void PoplateList()
        {
            listViewMovies.ClearObjects();
            listViewMovies.SetObjects(MovieList);
            listViewMovies.Sort(ColDate, SortOrder.Descending);

            listViewEps.ClearObjects();
            listViewEps.SetObjects(EpsList);
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
            new MediaFunctions().LoadMediaFromFolder(Properties.Settings.Default.MoviePath, Properties.Settings.Default.EpisodePath, ref MovieList, ref EpsList, ref MediaList);
            PoplateList();
        }

        private void listViewMovies_DoubleClick(object sender, EventArgs e)
        {
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
        }

        private void listViewEps_DoubleClick(object sender, EventArgs e)
        {
            MediaItem MediaObj = listViewEps.SelectedObjects[0] as MediaItem;
            System.Diagnostics.Process.Start(MediaObj.FullPath);
        }


        private void butSettings_Click(object sender, EventArgs e)
        { 
            frmSettings fSettings = new frmSettings(){MainForm = this} ;
            fSettings.ShowDialog();
        }


        private void butShare_Click(object sender, EventArgs e)
        {
            new ShareMediaFunctions().ShareMedia(MediaList);
            MessageBox.Show("Sharing Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            
          /*              
            watchTowerData.Serieses.Add(new Series{
                Name = "SeriesTest1"
            });
            WatchTowerData.SaveChanges();
            */

            var s = WTEntities.Series.Find(1);

        }
    }
}
