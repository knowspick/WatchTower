namespace WatchTower
{
    partial class WatchTower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchTower));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewMovies = new BrightIdeasSoftware.ObjectListView();
            this.ColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ColDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewEps = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEpsDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.butShare = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewEps)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 422);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 396);
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
            this.listViewMovies.Location = new System.Drawing.Point(6, 6);
            this.listViewMovies.MenuLabelColumns = "";
            this.listViewMovies.MenuLabelGroupBy = "";
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.ShowGroups = false;
            this.listViewMovies.Size = new System.Drawing.Size(763, 384);
            this.listViewMovies.SortGroupItemsByPrimaryColumn = false;
            this.listViewMovies.TabIndex = 10;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            this.listViewMovies.SelectedIndexChanged += new System.EventHandler(this.listViewMovies_SelectedIndexChanged);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Episodes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewEps
            // 
            this.listViewEps.AllColumns.Add(this.olvColumn1);
            this.listViewEps.AllColumns.Add(this.colEpsDate);
            this.listViewEps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.colEpsDate});
            this.listViewEps.Location = new System.Drawing.Point(6, 6);
            this.listViewEps.MenuLabelColumns = "";
            this.listViewEps.MenuLabelGroupBy = "";
            this.listViewEps.Name = "listViewEps";
            this.listViewEps.ShowGroups = false;
            this.listViewEps.Size = new System.Drawing.Size(760, 338);
            this.listViewEps.SortGroupItemsByPrimaryColumn = false;
            this.listViewEps.TabIndex = 11;
            this.listViewEps.UseCompatibleStateImageBehavior = false;
            this.listViewEps.View = System.Windows.Forms.View.Details;
            this.listViewEps.DoubleClick += new System.EventHandler(this.listViewEps_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 359;
            // 
            // colEpsDate
            // 
            this.colEpsDate.AspectName = "DateAdded";
            this.colEpsDate.AspectToStringFormat = "{0:dd/MM/yyyy   HH:mm:ss}";
            this.colEpsDate.CellPadding = null;
            this.colEpsDate.IsEditable = false;
            this.colEpsDate.Text = "Date";
            this.colEpsDate.UseFiltering = false;
            this.colEpsDate.Width = 164;
            // 
            // butShare
            // 
            this.butShare.Location = new System.Drawing.Point(431, 12);
            this.butShare.Name = "butShare";
            this.butShare.Size = new System.Drawing.Size(95, 40);
            this.butShare.TabIndex = 12;
            this.butShare.Text = "Share";
            this.butShare.UseVisualStyleBackColor = true;
            this.butShare.Click += new System.EventHandler(this.butShare_Click);
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(681, 12);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(114, 23);
            this.butSettings.TabIndex = 13;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // WatchTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 493);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.butShare);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WatchTower";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewEps)).EndInit();
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
        private System.Windows.Forms.Button butShare;
        private System.Windows.Forms.Button butSettings;
    }
}

