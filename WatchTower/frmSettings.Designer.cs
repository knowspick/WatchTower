namespace WatchTower
{
    partial class frmSettings
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.butSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butEpsDir = new System.Windows.Forms.Button();
            this.butMovieDir = new System.Windows.Forms.Button();
            this.textMoviePath = new System.Windows.Forms.TextBox();
            this.textEpsPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butShareEpsDir = new System.Windows.Forms.Button();
            this.butShareMovieDir = new System.Windows.Forms.Button();
            this.textShareMoviePath = new System.Windows.Forms.TextBox();
            this.textShareEpsPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSaveSettings
            // 
            this.butSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveSettings.Location = new System.Drawing.Point(438, 196);
            this.butSaveSettings.Name = "butSaveSettings";
            this.butSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.butSaveSettings.TabIndex = 14;
            this.butSaveSettings.Text = "Save";
            this.butSaveSettings.UseVisualStyleBackColor = true;
            this.butSaveSettings.Click += new System.EventHandler(this.butSaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butEpsDir);
            this.groupBox1.Controls.Add(this.butMovieDir);
            this.groupBox1.Controls.Add(this.textMoviePath);
            this.groupBox1.Controls.Add(this.textEpsPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media Settings";
            // 
            // butEpsDir
            // 
            this.butEpsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEpsDir.Location = new System.Drawing.Point(470, 19);
            this.butEpsDir.Name = "butEpsDir";
            this.butEpsDir.Size = new System.Drawing.Size(25, 23);
            this.butEpsDir.TabIndex = 25;
            this.butEpsDir.Text = "...";
            this.butEpsDir.UseVisualStyleBackColor = true;
            this.butEpsDir.Click += new System.EventHandler(this.butEpsDir_Click);
            // 
            // butMovieDir
            // 
            this.butMovieDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMovieDir.Location = new System.Drawing.Point(470, 45);
            this.butMovieDir.Name = "butMovieDir";
            this.butMovieDir.Size = new System.Drawing.Size(25, 23);
            this.butMovieDir.TabIndex = 24;
            this.butMovieDir.Text = "...";
            this.butMovieDir.UseVisualStyleBackColor = true;
            this.butMovieDir.Click += new System.EventHandler(this.butMovieDir_Click_1);
            // 
            // textMoviePath
            // 
            this.textMoviePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMoviePath.Location = new System.Drawing.Point(62, 47);
            this.textMoviePath.Name = "textMoviePath";
            this.textMoviePath.Size = new System.Drawing.Size(402, 20);
            this.textMoviePath.TabIndex = 23;
            // 
            // textEpsPath
            // 
            this.textEpsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEpsPath.Location = new System.Drawing.Point(62, 21);
            this.textEpsPath.Name = "textEpsPath";
            this.textEpsPath.Size = new System.Drawing.Size(402, 20);
            this.textEpsPath.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Episodes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butShareEpsDir);
            this.groupBox2.Controls.Add(this.butShareMovieDir);
            this.groupBox2.Controls.Add(this.textShareMoviePath);
            this.groupBox2.Controls.Add(this.textShareEpsPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 83);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Share Settings";
            // 
            // butShareEpsDir
            // 
            this.butShareEpsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butShareEpsDir.Location = new System.Drawing.Point(470, 19);
            this.butShareEpsDir.Name = "butShareEpsDir";
            this.butShareEpsDir.Size = new System.Drawing.Size(25, 23);
            this.butShareEpsDir.TabIndex = 31;
            this.butShareEpsDir.Text = "...";
            this.butShareEpsDir.UseVisualStyleBackColor = true;
            this.butShareEpsDir.Click += new System.EventHandler(this.butShareEpsDir_Click);
            // 
            // butShareMovieDir
            // 
            this.butShareMovieDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butShareMovieDir.Location = new System.Drawing.Point(470, 45);
            this.butShareMovieDir.Name = "butShareMovieDir";
            this.butShareMovieDir.Size = new System.Drawing.Size(25, 23);
            this.butShareMovieDir.TabIndex = 30;
            this.butShareMovieDir.Text = "...";
            this.butShareMovieDir.UseVisualStyleBackColor = true;
            this.butShareMovieDir.Click += new System.EventHandler(this.butShareMovieDir_Click);
            // 
            // textShareMoviePath
            // 
            this.textShareMoviePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textShareMoviePath.Location = new System.Drawing.Point(62, 47);
            this.textShareMoviePath.Name = "textShareMoviePath";
            this.textShareMoviePath.Size = new System.Drawing.Size(402, 20);
            this.textShareMoviePath.TabIndex = 29;
            // 
            // textShareEpsPath
            // 
            this.textShareEpsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textShareEpsPath.Location = new System.Drawing.Point(62, 21);
            this.textShareEpsPath.Name = "textShareEpsPath";
            this.textShareEpsPath.Size = new System.Drawing.Size(402, 20);
            this.textShareEpsPath.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Movies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Episodes";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 231);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSaveSettings);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button butSaveSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butEpsDir;
        private System.Windows.Forms.Button butMovieDir;
        private System.Windows.Forms.TextBox textMoviePath;
        private System.Windows.Forms.TextBox textEpsPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butShareEpsDir;
        private System.Windows.Forms.Button butShareMovieDir;
        private System.Windows.Forms.TextBox textShareMoviePath;
        private System.Windows.Forms.TextBox textShareEpsPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}