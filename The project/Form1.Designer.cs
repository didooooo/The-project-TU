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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::The_project.Properties.Resources.dashboard;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(62, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFavourite
            // 
            this.btnFavourite.FlatAppearance.BorderSize = 0;
            this.btnFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourite.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFavourite.ForeColor = System.Drawing.Color.White;
            this.btnFavourite.Image = global::The_project.Properties.Resources.dashboard;
            this.btnFavourite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourite.Location = new System.Drawing.Point(62, 259);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(55, 51);
            this.btnFavourite.TabIndex = 7;
            this.btnFavourite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavourite.UseVisualStyleBackColor = true;
            // 
            // btnReviews
            // 
            this.btnReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReviews.ForeColor = System.Drawing.Color.White;
            this.btnReviews.Image = global::The_project.Properties.Resources.dashboard;
            this.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviews.Location = new System.Drawing.Point(62, 202);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(55, 51);
            this.btnReviews.TabIndex = 6;
            this.btnReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContactUs.ForeColor = System.Drawing.Color.White;
            this.btnContactUs.Image = global::The_project.Properties.Resources.dashboard;
            this.btnContactUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactUs.Location = new System.Drawing.Point(62, 316);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(55, 51);
            this.btnContactUs.TabIndex = 5;
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowDrop = true;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Variable Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::The_project.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(62, 132);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(55, 51);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(293, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 116);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "By your choice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(577, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 116);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 74);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search by data \r\nfor country\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRandom);
            this.panel3.Location = new System.Drawing.Point(293, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 116);
            this.panel3.TabIndex = 5;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(34, 20);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(176, 74);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Generate random \r\ncountry\r\n";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCompare);
            this.panel4.Location = new System.Drawing.Point(577, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 116);
            this.panel4.TabIndex = 5;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(15, 20);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(186, 74);
            this.btnCompare.TabIndex = 10;
            this.btnCompare.Text = "Compare countries\r\n";
            this.btnCompare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your destination";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button btnRandom;
        private Button btnCompare;
    }
}