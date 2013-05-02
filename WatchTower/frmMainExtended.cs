using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WatchTower.Entities;

namespace WatchTower
{
    public partial class frmMain
    {
        #region Declarations
        WatchTowerEF WTContext;
        List<Episode> AvailableEpisodes = new List<Episode>();
        List<Profile> SelectedProfiles = new List<Profile>();
        FlowLayoutPanel SeletedSeriesControl;

        Boolean HideEdpisodeList = false;

        public class DisplaySeries
        {
            public Series series;
            public List<Episode> epsisodes = new List<Episode>();
        }
        #endregion

        #region Retrieve Series data and apply filters
        private void PoplateList () {
            //Episodes         
            flowEpisodeList.Visible = false;

            if (SelectedProfiles.Count == 0) {
                flowLayoutPanelMain.Visible = false;
                return;
            } else
                flowLayoutPanelMain.Visible = true;


            //***** Filter Un WantedSeries *****    
            //the 3 lists we need to popluate
            List<Episode> WantedEps = new List<Episode>();
            List<Episode> UnratedEps = new List<Episode>();
            List<Episode> UnWantedEps = new List<Episode>();

            //get list accourding to selected profiles
            List<ProfileSeriesRel> WantSeriesRel = new List<ProfileSeriesRel>();
            List<ProfileSeriesRel> UnWantedSeriesRel = new List<ProfileSeriesRel>();
            List<ProfileEpisodeRel> WatchedEpisodeRel = new List<ProfileEpisodeRel>();
            foreach (Profile profile in SelectedProfiles) {
                WantSeriesRel.AddRange(profile.ProfileSeriesRel.Where<ProfileSeriesRel>(
                        psr => psr.WantToWatch == true
                    ).ToList<ProfileSeriesRel>()
                );
                UnWantedSeriesRel.AddRange(profile.ProfileSeriesRel.Where<ProfileSeriesRel>(
                        psr => psr.WantToWatch == false
                    ).ToList<ProfileSeriesRel>()
                );
                WatchedEpisodeRel.AddRange(profile.ProfileEpisodeRel.Where<ProfileEpisodeRel>(
                    pes => pes.Watched == true
                    ).ToList<ProfileEpisodeRel>()
                );
            }

            //unrated is everything left
            UnratedEps = new List<Episode>(AvailableEpisodes);
            //fisrt remove al watched episodes
            foreach (var item in WatchedEpisodeRel)
                UnratedEps.RemoveAll(e => e.Id == item.EpisodeId);

            //get don't want to watch list
            foreach (var item in UnWantedSeriesRel) {
                UnWantedEps.AddRange(UnratedEps.Where<Episode>(e => e.Series == item.Series));
                UnratedEps.RemoveAll(e => e.Series == item.Series);
                //UnratedEps.Except(UnWantedEps);
            }

            //get wanttowatch list
            foreach (var item in WantSeriesRel) {
                WantedEps.AddRange(UnratedEps.Where<Episode>(e => e.SeriesId == item.SeriesId));
                UnratedEps.RemoveAll(e => e.SeriesId == item.SeriesId);
                //UnratedEps.Except(WantedEps);
            }


            //display the 3 list            
            DisplayListInFlowLayout(WantedEps, flowWanted);
            DisplayListInFlowLayout(UnratedEps, flowUnrated);
            DisplayListInFlowLayout(UnWantedEps, flowUnWanted);
        }
#endregion
        
        #region Display Series List
        private void DisplayListInFlowLayout (List<Episode> list, FlowLayoutPanel flow) {
            //to do: make ths "better"
            flow.Controls.Clear();

            List<DisplaySeries> DList = new List<DisplaySeries>();
            foreach (Episode eps in list) {
                DisplaySeries DSeries = DList.SingleOrDefault(ds => ds.series.Id == eps.SeriesId);
                if (DSeries == null) {
                    DSeries = new DisplaySeries() { series = eps.Series };
                    DList.Add(DSeries);
                }
                DSeries.epsisodes.Add(eps);
            }

            //now display the items atlast
            foreach (DisplaySeries ds in DList) {
                Font tfont = new Font("Calibri", 20, FontStyle.Bold);

                FlowLayoutPanel tp = new FlowLayoutPanel();
                tp.BackColor = Color.DarkBlue;
                tp.ForeColor = Color.LightGray;
                tp.AutoSize = true;
                tp.WrapContents = false;
                tp.Width = 351;
                tp.Height = 41;
                tp.Tag = ds;                

                Label ln = new Label();
                ln.Name = "number";                
                ln.Text = ds.epsisodes.Count.ToString();
                ln.Font = tfont;
                ln.Height = 33;
                ln.Width = 66;
                ln.Tag = ds;
                ln.Click += ln_Click;
                tp.Controls.Add(ln);

                Label lname = new Label();
                lname.Text = ds.series.Name;
                lname.Font = tfont;
                lname.Left = 38;
                lname.Height = 33;
                lname.Width = 272;
                lname.Tag = ds;
                lname.Click += lname_Click;
                tp.Controls.Add(lname);

                if (SelectedProfiles.Count == 1) {
                    FlowLayoutPanel flowBut = new FlowLayoutPanel();
                    flowBut.AutoSize = true;
                    flowBut.WrapContents = false;
                    if (flow.Name != "flowWanted") {
                        Button butWant = new Button();
                        butWant.Tag = ds;
                        butWant.Click += butWant_Click;
                        butWant.Text = "Want";
                        flowBut.Controls.Add(butWant);
                    }
                    if (flow.Name != "flowUnWanted") {
                        Button butDont = new Button();
                        butDont.Text = "Don't Want";
                        butDont.Click += butDont_Click;
                        butDont.Tag = ds;
                        flowBut.Controls.Add(butDont);
                    }
                    tp.Controls.Add(flowBut);
                }

                flow.Controls.Add(tp);
            }
        }

        void lname_Click (object sender, EventArgs e) {
            SeletedSeriesControl = ((sender as Label).Parent as FlowLayoutPanel);
            ShowEpisodeList(((sender as Label).Tag as DisplaySeries).epsisodes);
        }

        void ln_Click (object sender, EventArgs e) {
            SeletedSeriesControl = ((sender as Label).Parent as FlowLayoutPanel);
            ShowEpisodeList(((sender as Label).Tag as DisplaySeries).epsisodes);
        }

        void butDont_Click (object sender, EventArgs e) {
            ((sender as Button).Tag as DisplaySeries).series.SetRating(SelectedProfiles, false);
            WTContext.SaveChanges();
            PoplateList();
        }

        void butWant_Click (object sender, EventArgs e) {
            ((sender as Button).Tag as DisplaySeries).series.SetRating(SelectedProfiles, true);
            WTContext.SaveChanges();
            PoplateList();
        }
#endregion

        #region Display Episode List
        private int GetRelativeLeft (Control control) {
            int RelitiveLeft = control.Left;

            Control parentControl = control.Parent;
            while (!(parentControl is Form)) {
                RelitiveLeft += parentControl.Left;
                parentControl = parentControl.Parent;
            }
            return RelitiveLeft;
        }

        private int GetRelativeTop (Control control) {
            int RelitiveTop = control.Top;

            Control parentControl = control.Parent;
            while (!(parentControl is Form)) {
                RelitiveTop += parentControl.Top;
                parentControl = parentControl.Parent;
            }
            return RelitiveTop;
        }

        void ShowEpisodeList (List<Episode> episodes) {
            flowEpisodeList.Controls.Clear();
            flowEpisodeList.Left = GetRelativeLeft(flowLayoutPanelMain) + 200;
            flowEpisodeList.Top = GetRelativeTop(flowLayoutPanelMain) + 5;
            flowEpisodeList.Width = flowLayoutPanelMain.Width - flowEpisodeList.Left;
            flowEpisodeList.Height = flowLayoutPanelMain.Height - 10;
            flowEpisodeList.Visible = true;
            flowEpisodeList.Focus();
            HideEdpisodeList = false;

            Font tfont = new Font("Calibri", 20, FontStyle.Bold);

            foreach (Episode eps in episodes) {
                FlowLayoutPanel tp = new FlowLayoutPanel();
                tp.BackColor = Color.DarkBlue;
                tp.ForeColor = Color.LightGray;
                tp.AutoSize = false;
                tp.WrapContents = false;
                tp.Width = flowEpisodeList.Width - 30;
                tp.Height = 41;

                Label ln = new Label();
                ln.Text = "S" + eps.SeasonNo.ToString("00") + " E" + eps.EpisodeNo.ToString("00");
                ln.Text += " " + eps.Name;
                ln.Font = tfont;
                ln.Height = 33;
                ln.Width = tp.Width - 170;
                ln.Tag = eps.FileFullPath;
                ln.DoubleClick += ln_DoubleClick;
                tp.Controls.Add(ln);

                Button butPlayEps = new Button();
                butPlayEps.Tag = eps.FileFullPath;
                butPlayEps.Click += butPlayEps_Click;
                butPlayEps.Text = "Play";
                tp.Controls.Add(butPlayEps);

                Button butWatchedEps = new Button();
                butWatchedEps.Tag = eps;
                butWatchedEps.Click += butWatchedEps_Click;
                butWatchedEps.Text = "Watched";
                tp.Controls.Add(butWatchedEps);

                flowEpisodeList.Controls.Add(tp);
            }

        }

        void ln_DoubleClick (object sender, EventArgs e) {
            System.Diagnostics.Process.Start(((sender as Label).Tag as string));
        }

        void butWatchedEps_Click (object sender, EventArgs e) {
            //to do: seriesly need to implement this better.
            //one day when i have time. haha
            Button but = (sender as Button);
            Episode eps = (but.Tag as Episode);
            eps.SetWatched(SelectedProfiles, true);
            WTContext.SaveChanges();

            //remove episode control
            flowEpisodeList.Controls.Remove(but.Parent);
            //remove and update list
            DisplaySeries ds = (SeletedSeriesControl.Tag as DisplaySeries);
            ds.epsisodes.Remove(eps);
            if (ds.epsisodes.Count > 0)
            {
                Label ln = (SeletedSeriesControl.Controls.Find("number",false)[0] as Label);
                ln.Text = ds.epsisodes.Count.ToString();
            }
            else
                SeletedSeriesControl.Parent.Controls.Remove(SeletedSeriesControl);
            
        }

        void butPlayEps_Click (object sender, EventArgs e) {
            System.Diagnostics.Process.Start(((sender as Button).Tag as string));
        }

        private void HideEpisodeListCheck () {
            if (HideEdpisodeList)
                flowEpisodeList.Visible = false;
        }
#endregion

        #region Profile Buttons
        private void SetProfileButtons () {
            //set profile button
            List<CheckBox> profilesBut = new List<CheckBox>();
            foreach (Profile profile in WTContext.Profiles) {
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

        void chkNew_CheckedChanged (object sender, EventArgs e) {
            CheckBox chkbox = (sender as CheckBox);
            if (chkbox.Checked) {
                chkbox.BackColor = Color.DarkBlue;
            } else {
                chkbox.BackColor = Color.WhiteSmoke;
            }

            SelectedProfiles.Clear();
            foreach (CheckBox chk in panelProfiles.Controls) {
                if (chk.Checked)
                    SelectedProfiles.Add(WTContext.Profiles.SingleOrDefault(pro => pro.Id == (Int64)chk.Tag));
            }
            PoplateList();
        }

        #endregion
    }
}
