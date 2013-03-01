using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchTower
{
    public partial class frmSettings : Form
    {
        public WatchTower MainForm;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MoviePath = textMoviePath.Text;
            Properties.Settings.Default.EpisodePath = textEpsPath.Text;
            Properties.Settings.Default.ShareEpisodePath = textShareEpsPath.Text;
            Properties.Settings.Default.ShareMoviePath = textShareMoviePath.Text;
            Properties.Settings.Default.FontSize = Decimal.ToInt32(NumUDFontSize.Value);
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            textMoviePath.Text = Properties.Settings.Default.MoviePath;
            textEpsPath.Text = Properties.Settings.Default.EpisodePath;
            textShareEpsPath.Text = Properties.Settings.Default.ShareEpisodePath;
            textShareMoviePath.Text = Properties.Settings.Default.ShareMoviePath;
            NumUDFontSize.Value = Properties.Settings.Default.FontSize;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void butSaveSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void butShareEpsDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textShareEpsPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void butShareMovieDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textShareMoviePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void butEpsDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textEpsPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void butMovieDir_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textMoviePath.Text = folderBrowserDialog.SelectedPath;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SetFontSize(Decimal.ToInt32(NumUDFontSize.Value)); 
        }


    }
}
