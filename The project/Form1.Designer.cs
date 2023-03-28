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
            showMore = new Button();
            sidePanel = new Panel();
            labelName = new Label();
            btnExit = new Button();
            btnFavourite = new Button();
            btnReviews = new Button();
            btnContactUs = new Button();
            btnDashboard = new Button();
            iconProfile = new PictureBox();
            checkBox1 = new CheckBox();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconProfile).BeginInit();
            SuspendLayout();
            // 
            // showMore
            // 
            showMore.BackgroundImage = (Image)resources.GetObject("showMore.BackgroundImage");
            showMore.BackgroundImageLayout = ImageLayout.Zoom;
            showMore.FlatAppearance.BorderSize = 0;
            showMore.FlatStyle = FlatStyle.Flat;
            showMore.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            showMore.Location = new Point(4, 7);
            showMore.Margin = new Padding(2);
            showMore.Name = "showMore";
            showMore.Size = new Size(25, 20);
            showMore.TabIndex = 2;
            showMore.UseVisualStyleBackColor = true;
            showMore.Click += showMore_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Coral;
            sidePanel.Controls.Add(labelName);
            sidePanel.Controls.Add(btnExit);
            sidePanel.Controls.Add(btnFavourite);
            sidePanel.Controls.Add(btnReviews);
            sidePanel.Controls.Add(btnContactUs);
            sidePanel.Controls.Add(btnDashboard);
            sidePanel.Controls.Add(iconProfile);
            sidePanel.Controls.Add(showMore);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(2);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(150, 308);
            sidePanel.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(29, 61);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 15);
            labelName.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = Properties.Resources.dashboard;
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Location = new Point(43, 251);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 31);
            btnExit.TabIndex = 8;
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFavourite
            // 
            btnFavourite.FlatAppearance.BorderSize = 0;
            btnFavourite.FlatStyle = FlatStyle.Flat;
            btnFavourite.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavourite.Image = Properties.Resources.dashboard;
            btnFavourite.ImageAlign = ContentAlignment.MiddleRight;
            btnFavourite.Location = new Point(43, 155);
            btnFavourite.Margin = new Padding(2);
            btnFavourite.Name = "btnFavourite";
            btnFavourite.Size = new Size(38, 31);
            btnFavourite.TabIndex = 7;
            btnFavourite.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFavourite.UseVisualStyleBackColor = true;
            // 
            // btnReviews
            // 
            btnReviews.FlatAppearance.BorderSize = 0;
            btnReviews.FlatStyle = FlatStyle.Flat;
            btnReviews.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReviews.Image = Properties.Resources.dashboard;
            btnReviews.ImageAlign = ContentAlignment.MiddleRight;
            btnReviews.Location = new Point(43, 121);
            btnReviews.Margin = new Padding(2);
            btnReviews.Name = "btnReviews";
            btnReviews.Size = new Size(38, 31);
            btnReviews.TabIndex = 6;
            btnReviews.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.Image = Properties.Resources.dashboard;
            btnContactUs.ImageAlign = ContentAlignment.MiddleRight;
            btnContactUs.Location = new Point(43, 190);
            btnContactUs.Margin = new Padding(2);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(38, 31);
            btnContactUs.TabIndex = 5;
            btnContactUs.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleRight;
            btnDashboard.Location = new Point(43, 79);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(38, 31);
            btnDashboard.TabIndex = 4;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // iconProfile
            // 
            iconProfile.ErrorImage = null;
            iconProfile.Image = Properties.Resources.user__1_;
            iconProfile.InitialImage = null;
            iconProfile.Location = new Point(43, 7);
            iconProfile.Margin = new Padding(2);
            iconProfile.Name = "iconProfile";
            iconProfile.Size = new Size(69, 52);
            iconProfile.SizeMode = PictureBoxSizeMode.Zoom;
            iconProfile.TabIndex = 3;
            iconProfile.TabStop = false;
            iconProfile.Click += iconProfile_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(266, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(631, 308);
            Controls.Add(checkBox1);
            Controls.Add(sidePanel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox checkBox1;
    }
}