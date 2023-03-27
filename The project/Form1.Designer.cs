namespace The_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showMore = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFavourite = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.iconProfile = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // showMore
            // 
            this.showMore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showMore.BackgroundImage")));
            this.showMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showMore.FlatAppearance.BorderSize = 0;
            this.showMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMore.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showMore.Location = new System.Drawing.Point(6, 12);
            this.showMore.Name = "showMore";
            this.showMore.Size = new System.Drawing.Size(36, 34);
            this.showMore.TabIndex = 2;
            this.showMore.UseVisualStyleBackColor = true;
            this.showMore.Click += new System.EventHandler(this.showMore_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Coral;
            this.sidePanel.Controls.Add(this.labelName);
            this.sidePanel.Controls.Add(this.btnExit);
            this.sidePanel.Controls.Add(this.btnFavourite);
            this.sidePanel.Controls.Add(this.btnReviews);
            this.sidePanel.Controls.Add(this.btnContactUs);
            this.sidePanel.Controls.Add(this.btnDashboard);
            this.sidePanel.Controls.Add(this.iconProfile);
            this.sidePanel.Controls.Add(this.showMore);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(214, 513);
            this.sidePanel.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 25);
            this.labelName.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Image = global::The_project.Properties.Resources.dashboard;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(62, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFavourite
            // 
            this.btnFavourite.FlatAppearance.BorderSize = 0;
            this.btnFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourite.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFavourite.Image = global::The_project.Properties.Resources.dashboard;
            this.btnFavourite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavourite.Location = new System.Drawing.Point(62, 259);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(55, 51);
            this.btnFavourite.TabIndex = 7;
            this.btnFavourite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFavourite.UseVisualStyleBackColor = true;
            // 
            // btnReviews
            // 
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReviews.Image = global::The_project.Properties.Resources.dashboard;
            this.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReviews.Location = new System.Drawing.Point(62, 202);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(55, 51);
            this.btnReviews.TabIndex = 6;
            this.btnReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContactUs.Image = global::The_project.Properties.Resources.dashboard;
            this.btnContactUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContactUs.Location = new System.Drawing.Point(62, 316);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(55, 51);
            this.btnContactUs.TabIndex = 5;
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::The_project.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(62, 132);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(55, 51);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // iconProfile
            // 
            this.iconProfile.ErrorImage = null;
            this.iconProfile.Image = global::The_project.Properties.Resources.user__1_;
            this.iconProfile.InitialImage = null;
            this.iconProfile.Location = new System.Drawing.Point(62, 12);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Size = new System.Drawing.Size(98, 87);
            this.iconProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconProfile.TabIndex = 3;
            this.iconProfile.TabStop = false;
            this.iconProfile.Click += new System.EventHandler(this.iconProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.sidePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button showMore;
        private Panel sidePanel;
        private PictureBox iconProfile;
        private Button btnDashboard;
        private Button btnExit;
        private Button btnFavourite;
        private Button btnReviews;
        private Button btnContactUs;
        private Label labelName;
    }
}