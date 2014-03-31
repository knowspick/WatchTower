using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServiceStack.OrmLite;
using ServiceStack.Common.Utils;
using WatchTower.POCO;

namespace WatchTower
{
    public partial class frmMain : Form
    {
        private System.Data.IDbConnection _db;

        private System.Data.IDbConnection db
        {
            get
            {
                if (_db == null)
                {
                    string SqliteFileDb = @"WatchTower_testx.db".MapAbsolutePath();
                    var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, false, SqliteDialect.Provider);
                    _db = dbFactory.Open();
                }
                return _db;
            }
        }

        private ProfileController _AllProfiles;
        private List<Profile> _SelectProfiles;

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
            //WTContext = new WatchTowerEF();
            //System.Data.Entity.Database.SetInitializer<WatchTowerEF>(null);

            timerUpdateFiles.Interval = 1;
        }

        private void butSettings_Click(object sender, EventArgs e)
        { 
            frmSettings fSettings = new frmSettings(){MainForm = this} ;
            fSettings.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            _AllProfiles = new ProfileController(db).GetAllProfiles;
            //SetProfileButtons();
        }

        private void timerUpdateFiles_Tick(object sender, EventArgs e)
        {
            timerUpdateFiles.Interval = 1800000;
            //AvailableEpisodes = MediaFunctions.UpdateEpisodesFromFolder(WTContext);
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

        private void testBut_Click(object sender, EventArgs e)
        {
            _AllProfiles = new ProfileController(db).GetAllProfiles();            
        }


    }
}
