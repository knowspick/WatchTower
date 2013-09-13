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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWanted = new System.Windows.Forms.Label();
            this.flowWanted = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowUnrated = new System.Windows.Forms.FlowLayoutPanel();
            this.Dpanel = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowUnWanted = new System.Windows.Forms.FlowLayoutPanel();
            this.flowEpisodeList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProfiles = new System.Windows.Forms.Panel();
            this.butSettings = new System.Windows.Forms.Button();
            this.timerUpdateFiles = new System.Windows.Forms.Timer(this.components);
            this.testBut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.flowUnrated.SuspendLayout();
            this.Dpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 472);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.flowLayoutPanelMain);
            this.tabPage3.Controls.Add(this.flowEpisodeList);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(977, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Episodes";
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
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(513, 430);
            this.flowLayoutPanelMain.TabIndex = 0;
            this.flowLayoutPanelMain.Visible = false;
            this.flowLayoutPanelMain.WrapContents = false;
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
            // flowWanted
            // 
            this.flowWanted.AutoSize = true;
            this.flowWanted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowWanted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowWanted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowWanted.Location = new System.Drawing.Point(3, 22);
            this.flowWanted.MinimumSize = new System.Drawing.Size(400, 50);
            this.flowWanted.Name = "flowWanted";
            this.flowWanted.Size = new System.Drawing.Size(400, 50);
            this.flowWanted.TabIndex = 0;
            this.flowWanted.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.MinimumSize = new System.Drawing.Size(400, 2);
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
            this.flowUnrated.Controls.Add(this.Dpanel);
            this.flowUnrated.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUnrated.Location = new System.Drawing.Point(3, 99);
            this.flowUnrated.MinimumSize = new System.Drawing.Size(400, 50);
            this.flowUnrated.Name = "flowUnrated";
            this.flowUnrated.Size = new System.Drawing.Size(400, 50);
            this.flowUnrated.TabIndex = 1;
            this.flowUnrated.WrapContents = false;
            // 
            // Dpanel
            // 
            this.Dpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Dpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Dpanel.Controls.Add(this.lblName);
            this.Dpanel.Controls.Add(this.lblNo);
            this.Dpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dpanel.Location = new System.Drawing.Point(3, 3);
            this.Dpanel.Name = "Dpanel";
            this.Dpanel.Size = new System.Drawing.Size(351, 41);
            this.Dpanel.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(272, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Dancing with the starts";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(3, 3);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(43, 33);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.MinimumSize = new System.Drawing.Size(400, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "UnWanted";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowUnWanted
            // 
            this.flowUnWanted.AutoSize = true;
            this.flowUnWanted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowUnWanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowUnWanted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowUnWanted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUnWanted.Location = new System.Drawing.Point(3, 176);
            this.flowUnWanted.MinimumSize = new System.Drawing.Size(400, 50);
            this.flowUnWanted.Name = "flowUnWanted";
            this.flowUnWanted.Size = new System.Drawing.Size(400, 50);
            this.flowUnWanted.TabIndex = 2;
            this.flowUnWanted.WrapContents = false;
            // 
            // flowEpisodeList
            // 
            this.flowEpisodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowEpisodeList.AutoScroll = true;
            this.flowEpisodeList.BackColor = System.Drawing.Color.White;
            this.flowEpisodeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowEpisodeList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowEpisodeList.Location = new System.Drawing.Point(522, 6);
            this.flowEpisodeList.MinimumSize = new System.Drawing.Size(20, 20);
            this.flowEpisodeList.Name = "flowEpisodeList";
            this.flowEpisodeList.Size = new System.Drawing.Size(447, 427);
            this.flowEpisodeList.TabIndex = 18;
            this.flowEpisodeList.WrapContents = false;
            // 
            // panelProfiles
            // 
            this.panelProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfiles.Location = new System.Drawing.Point(746, 12);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(248, 41);
            this.panelProfiles.TabIndex = 16;
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(481, 12);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(133, 27);
            this.butSettings.TabIndex = 13;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // timerUpdateFiles
            // 
            this.timerUpdateFiles.Interval = 1800000;
            this.timerUpdateFiles.Tick += new System.EventHandler(this.timerUpdateFiles_Tick);
            // 
            // testBut
            // 
            this.testBut.Location = new System.Drawing.Point(304, 19);
            this.testBut.Name = "testBut";
            this.testBut.Size = new System.Drawing.Size(36, 23);
            this.testBut.TabIndex = 17;
            this.testBut.Text = "Test";
            this.testBut.UseVisualStyleBackColor = true;
            this.testBut.Click += new System.EventHandler(this.testBut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 508);
            this.Controls.Add(this.testBut);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelMain.PerformLayout();
            this.flowUnrated.ResumeLayout(false);
            this.Dpanel.ResumeLayout(false);
            this.Dpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Panel panelProfiles;
        private System.Windows.Forms.Timer timerUpdateFiles;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Label labelWanted;
        private System.Windows.Forms.FlowLayoutPanel flowWanted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowUnrated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowUnWanted;
        private System.Windows.Forms.Panel Dpanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button testBut;
        private System.Windows.Forms.FlowLayoutPanel flowEpisodeList;
    }
}

