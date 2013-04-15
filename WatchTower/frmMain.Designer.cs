namespace WatchTower
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewMovies = new BrightIdeasSoftware.ObjectListView();
            this.ColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ColDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewEps = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEpsName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEpsSeasonNum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEpsNum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEpsDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.butSettings = new System.Windows.Forms.Button();
            this.panelProfiles = new System.Windows.Forms.Panel();
            this.timerUpdateFiles = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowWanted = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWanted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowUnrated = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowUnWanted = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewEps)).BeginInit();
            this.popupMenu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 229);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewMovies
            // 
            this.listViewMovies.AllColumns.Add(this.ColName);
            this.listViewMovies.AllColumns.Add(this.ColDate);
            this.listViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColDate});
            this.listViewMovies.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMovies.Location = new System.Drawing.Point(7, 7);
            this.listViewMovies.MenuLabelColumns = "";
            this.listViewMovies.MenuLabelGroupBy = "";
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.ShowGroups = false;
            this.listViewMovies.Size = new System.Drawing.Size(889, 453);
            this.listViewMovies.SortGroupItemsByPrimaryColumn = false;
            this.listViewMovies.TabIndex = 10;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            this.listViewMovies.DoubleClick += new System.EventHandler(this.listViewMovies_DoubleClick);
            // 
            // ColName
            // 
            this.ColName.AspectName = "Name";
            this.ColName.CellPadding = null;
            this.ColName.Groupable = false;
            this.ColName.IsEditable = false;
            this.ColName.Text = "Name";
            this.ColName.Width = 337;
            // 
            // ColDate
            // 
            this.ColDate.AspectName = "DateAdded";
            this.ColDate.AspectToStringFormat = "{0:dd/MM/yyyy   HH:mm:ss}";
            this.ColDate.CellPadding = null;
            this.ColDate.Groupable = false;
            this.ColDate.IsEditable = false;
            this.ColDate.Text = "Date";
            this.ColDate.UseFiltering = false;
            this.ColDate.Width = 187;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewEps);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Episodes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewEps
            // 
            this.listViewEps.AllColumns.Add(this.olvColumn1);
            this.listViewEps.AllColumns.Add(this.colEpsName);
            this.listViewEps.AllColumns.Add(this.colEpsSeasonNum);
            this.listViewEps.AllColumns.Add(this.colEpsNum);
            this.listViewEps.AllColumns.Add(this.colEpsDate);
            this.listViewEps.AlternateRowBackColor = System.Drawing.Color.LightGray;
            this.listViewEps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.colEpsName,
            this.colEpsSeasonNum,
            this.colEpsNum,
            this.colEpsDate});
            this.listViewEps.ContextMenuStrip = this.popupMenu;
            this.listViewEps.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewEps.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEps.FullRowSelect = true;
            this.listViewEps.HighlightBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewEps.Location = new System.Drawing.Point(7, 7);
            this.listViewEps.MenuLabelColumns = "";
            this.listViewEps.MenuLabelGroupBy = "";
            this.listViewEps.MultiSelect = false;
            this.listViewEps.Name = "listViewEps";
            this.listViewEps.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.listViewEps.ShowGroups = false;
            this.listViewEps.Size = new System.Drawing.Size(886, 455);
            this.listViewEps.SortGroupItemsByPrimaryColumn = false;
            this.listViewEps.TabIndex = 11;
            this.listViewEps.UseCompatibleStateImageBehavior = false;
            this.listViewEps.UseFiltering = true;
            this.listViewEps.UseHotItem = true;
            this.listViewEps.UseTranslucentHotItem = true;
            this.listViewEps.UseTranslucentSelection = true;
            this.listViewEps.View = System.Windows.Forms.View.Details;
            this.listViewEps.DoubleClick += new System.EventHandler(this.listViewEps_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Series.Name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Series";
            this.olvColumn1.Width = 292;
            // 
            // colEpsName
            // 
            this.colEpsName.AspectName = "Name";
            this.colEpsName.CellPadding = null;
            this.colEpsName.FillsFreeSpace = true;
            this.colEpsName.IsEditable = false;
            this.colEpsName.Text = "Name";
            // 
            // colEpsSeasonNum
            // 
            this.colEpsSeasonNum.AspectName = "SeasonNo";
            this.colEpsSeasonNum.AspectToStringFormat = "S{0:00}";
            this.colEpsSeasonNum.CellPadding = null;
            this.colEpsSeasonNum.IsEditable = false;
            this.colEpsSeasonNum.Text = "";
            this.colEpsSeasonNum.Width = 51;
            // 
            // colEpsNum
            // 
            this.colEpsNum.AspectName = "EpisodeNo";
            this.colEpsNum.AspectToStringFormat = "E{0:00}";
            this.colEpsNum.CellPadding = null;
            this.colEpsNum.IsEditable = false;
            this.colEpsNum.Text = "Episode";
            this.colEpsNum.Width = 104;
            // 
            // colEpsDate
            // 
            this.colEpsDate.AspectName = "DateAddedToCollection";
            this.colEpsDate.AspectToStringFormat = "{0:dd/MM/yyyy   HH:mm:ss}";
            this.colEpsDate.CellPadding = null;
            this.colEpsDate.IsEditable = false;
            this.colEpsDate.Text = "Date";
            this.colEpsDate.UseFiltering = false;
            this.colEpsDate.Width = 164;
            // 
            // popupMenu
            // 
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Size = new System.Drawing.Size(221, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem1.Text = "Don\'t want to see this series";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(173, 12);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(133, 27);
            this.butSettings.TabIndex = 13;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // panelProfiles
            // 
            this.panelProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfiles.Location = new System.Drawing.Point(354, 12);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(235, 41);
            this.panelProfiles.TabIndex = 16;
            // 
            // timerUpdateFiles
            // 
            this.timerUpdateFiles.Enabled = true;
            this.timerUpdateFiles.Interval = 1800000;
            this.timerUpdateFiles.Tick += new System.EventHandler(this.timerUpdateFiles_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanelMain);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(567, 201);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Controls.Add(this.labelWanted);
            this.flowLayoutPanelMain.Controls.Add(this.flowWanted);
            this.flowLayoutPanelMain.Controls.Add(this.label1);
            this.flowLayoutPanelMain.Controls.Add(this.flowUnrated);
            this.flowLayoutPanelMain.Controls.Add(this.label2);
            this.flowLayoutPanelMain.Controls.Add(this.flowUnWanted);
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(558, 192);
            this.flowLayoutPanelMain.TabIndex = 0;
            this.flowLayoutPanelMain.WrapContents = false;
            // 
            // flowWanted
            // 
            this.flowWanted.AutoSize = true;
            this.flowWanted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowWanted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowWanted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowWanted.Location = new System.Drawing.Point(3, 22);
            this.flowWanted.MinimumSize = new System.Drawing.Size(100, 50);
            this.flowWanted.Name = "flowWanted";
            this.flowWanted.Size = new System.Drawing.Size(100, 50);
            this.flowWanted.TabIndex = 0;
            this.flowWanted.WrapContents = false;
            // 
            // labelWanted
            // 
            this.labelWanted.AutoSize = true;
            this.labelWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelWanted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWanted.Location = new System.Drawing.Point(3, 0);
            this.labelWanted.MinimumSize = new System.Drawing.Size(400, 0);
            this.labelWanted.Name = "labelWanted";
            this.labelWanted.Size = new System.Drawing.Size(400, 19);
            this.labelWanted.TabIndex = 1;
            this.labelWanted.Text = "Wanted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.MinimumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unrated";
            // 
            // flowUnrated
            // 
            this.flowUnrated.AutoSize = true;
            this.flowUnrated.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowUnrated.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowUnrated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowUnrated.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUnrated.Location = new System.Drawing.Point(3, 99);
            this.flowUnrated.MinimumSize = new System.Drawing.Size(100, 50);
            this.flowUnrated.Name = "flowUnrated";
            this.flowUnrated.Size = new System.Drawing.Size(100, 50);
            this.flowUnrated.TabIndex = 1;
            this.flowUnrated.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.MinimumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "UnWanted";
            // 
            // flowUnWanted
            // 
            this.flowUnWanted.AutoSize = true;
            this.flowUnWanted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowUnWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowUnWanted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowUnWanted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUnWanted.Location = new System.Drawing.Point(3, 176);
            this.flowUnWanted.MinimumSize = new System.Drawing.Size(100, 50);
            this.flowUnWanted.Name = "flowUnWanted";
            this.flowUnWanted.Size = new System.Drawing.Size(100, 50);
            this.flowUnWanted.TabIndex = 2;
            this.flowUnWanted.WrapContents = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 302);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewEps)).EndInit();
            this.popupMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView listViewMovies;
        private BrightIdeasSoftware.OLVColumn ColName;
        private BrightIdeasSoftware.OLVColumn ColDate;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView listViewEps;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn colEpsDate;
        private System.Windows.Forms.Button butSettings;
        private BrightIdeasSoftware.OLVColumn colEpsNum;
        private BrightIdeasSoftware.OLVColumn colEpsSeasonNum;
        private BrightIdeasSoftware.OLVColumn colEpsName;
        private System.Windows.Forms.Panel panelProfiles;
        private System.Windows.Forms.Timer timerUpdateFiles;
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Label labelWanted;
        private System.Windows.Forms.FlowLayoutPanel flowWanted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowUnrated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowUnWanted;
    }
}

