namespace WatchTower
{
    partial class frmProfiles
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
            this.listViewMovies = new BrightIdeasSoftware.ObjectListView();
            this.ColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMovies
            // 
            this.listViewMovies.AllColumns.Add(this.ColName);
            this.listViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName});
            this.listViewMovies.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMovies.Location = new System.Drawing.Point(12, 12);
            this.listViewMovies.MenuLabelColumns = "";
            this.listViewMovies.MenuLabelGroupBy = "";
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.ShowGroups = false;
            this.listViewMovies.Size = new System.Drawing.Size(403, 311);
            this.listViewMovies.SortGroupItemsByPrimaryColumn = false;
            this.listViewMovies.TabIndex = 11;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.AspectName = "Name";
            this.ColName.CellPadding = null;
            this.ColName.Groupable = false;
            this.ColName.IsEditable = false;
            this.ColName.Text = "Profile Name";
            this.ColName.Width = 337;
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 335);
            this.Controls.Add(this.listViewMovies);
            this.Name = "frmProfiles";
            this.Text = "frmProfiles";
            this.Load += new System.EventHandler(this.frmProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listViewMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView listViewMovies;
        private BrightIdeasSoftware.OLVColumn ColName;


    }
}