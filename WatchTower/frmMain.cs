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

        private void button1_Click(object sender, EventArgs e)
        {
            PoplateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WTContext = new WatchTowerEF();
            System.Data.Entity.Database.SetInitializer<WatchTowerEF>(null);

            timerUpdateFiles.Interval = 1;
        }

        private void butSettings_Click(object sender, EventArgs e)
        { 
            frmSettings fSettings = new frmSettings(){MainForm = this} ;
            fSettings.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            SetProfileButtons();
        }

        private void timerUpdateFiles_Tick(object sender, EventArgs e)
        {
            timerUpdateFiles.Interval = 1800000;
            AvailableEpisodes = MediaFunctions.UpdateEpisodesFromFolder(WTContext);
            PoplateList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectedProfiles.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            flowUnWanted.Visible = !flowUnWanted.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            /*
            WTContext.ProfileSeriesRels.SingleOrDefault<ProfileSeriesRel>(
                psr => psr.ProfileId == 1
                    && psr.SeriesId == 51
                ).WantToWatch = false;

            WTContext.SaveChanges();
             */
        }

        private void flowLayoutPanelMain_Click(object sender, EventArgs e)
        {
            HideEpisodeListCheck();
        }

        private void flowEpisodeList_Leave(object sender, EventArgs e)
        {
            HideEpisodeListCheck();
        }

        private void flowLayoutPanelMain_MouseEnter (object sender, EventArgs e) {
            HideEpisodeListCheck();
        }

        private void flowWanted_MouseEnter (object sender, EventArgs e) {
            HideEpisodeListCheck();
        }

        private void flowUnrated_MouseEnter (object sender, EventArgs e) {
            HideEpisodeListCheck();
        }

        private void flowUnWanted_MouseEnter (object sender, EventArgs e) {
            HideEpisodeListCheck();
        }

        private void frmMain_MouseEnter (object sender, EventArgs e) {
            HideEpisodeListCheck();
        }

        private void flowEpisodeList_MouseEnter (object sender, EventArgs e) {
            HideEdpisodeList = true;
        }

    }
}
