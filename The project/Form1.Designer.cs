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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            btnRandom = new Button();
            panel4 = new Panel();
            btnCompare = new Button();
            label1 = new Label();
            pnlMenu = new Panel();
            pnlByCh = new Panel();
            textBox1 = new TextBox();
            trcDur = new TrackBar();
            btnPrev = new Button();
            label3 = new Label();
            btnNext = new Button();
            label2 = new Label();
            textiBudgi = new TextBox();
            pnlByChoiceNxt = new Panel();
            btnPrev2 = new Button();
            label4 = new Label();
            btnNxt2 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            chEntertainment = new CheckBox();
            chSport = new CheckBox();
            chCulture = new CheckBox();
            cmbCulture = new ComboBox();
            cmbSport = new ComboBox();
            cmbEntertainment = new ComboBox();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconProfile).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlByCh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trcDur).BeginInit();
            pnlByChoiceNxt.SuspendLayout();
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
            sidePanel.Size = new Size(150, 630);
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
            btnExit.ForeColor = Color.White;
            btnExit.Image = Properties.Resources.dashboard;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(43, 573);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 31);
            btnExit.TabIndex = 8;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFavourite
            // 
            btnFavourite.FlatAppearance.BorderSize = 0;
            btnFavourite.FlatStyle = FlatStyle.Flat;
            btnFavourite.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavourite.ForeColor = Color.White;
            btnFavourite.Image = Properties.Resources.dashboard;
            btnFavourite.ImageAlign = ContentAlignment.MiddleLeft;
            btnFavourite.Location = new Point(43, 155);
            btnFavourite.Margin = new Padding(2);
            btnFavourite.Name = "btnFavourite";
            btnFavourite.Size = new Size(38, 31);
            btnFavourite.TabIndex = 7;
            btnFavourite.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFavourite.UseVisualStyleBackColor = true;
            // 
            // btnReviews
            // 
            btnReviews.Cursor = Cursors.Hand;
            btnReviews.FlatAppearance.BorderSize = 0;
            btnReviews.FlatStyle = FlatStyle.Flat;
            btnReviews.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReviews.ForeColor = Color.White;
            btnReviews.Image = Properties.Resources.dashboard;
            btnReviews.ImageAlign = ContentAlignment.MiddleLeft;
            btnReviews.Location = new Point(43, 121);
            btnReviews.Margin = new Padding(2);
            btnReviews.Name = "btnReviews";
            btnReviews.Size = new Size(38, 31);
            btnReviews.TabIndex = 6;
            btnReviews.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.White;
            btnContactUs.Image = Properties.Resources.dashboard;
            btnContactUs.ImageAlign = ContentAlignment.MiddleLeft;
            btnContactUs.Location = new Point(43, 190);
            btnContactUs.Margin = new Padding(2);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(38, 31);
            btnContactUs.TabIndex = 5;
            btnContactUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.AllowDrop = true;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(43, 79);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(38, 31);
            btnDashboard.TabIndex = 4;
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
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
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(41, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 70);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(24, 13);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 44);
            button1.TabIndex = 7;
            button1.Text = "By your choice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(240, 10);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 70);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(10, 13);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(130, 44);
            button2.TabIndex = 8;
            button2.Text = "Search by data \r\nfor country\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRandom);
            panel3.Location = new Point(41, 115);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 70);
            panel3.TabIndex = 5;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(24, 12);
            btnRandom.Margin = new Padding(2);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(123, 44);
            btnRandom.TabIndex = 9;
            btnRandom.Text = "Generate random \r\ncountry\r\n";
            btnRandom.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCompare);
            panel4.Location = new Point(240, 115);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 70);
            panel4.TabIndex = 5;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(10, 12);
            btnCompare.Margin = new Padding(2);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(130, 44);
            btnCompare.TabIndex = 10;
            btnCompare.Text = "Compare countries\r\n";
            btnCompare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose your destination";
            label1.Click += label1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(panel4);
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Location = new Point(186, 334);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(446, 226);
            pnlMenu.TabIndex = 6;
            // 
            // pnlByCh
            // 
            pnlByCh.Controls.Add(textBox1);
            pnlByCh.Controls.Add(trcDur);
            pnlByCh.Controls.Add(btnPrev);
            pnlByCh.Controls.Add(label3);
            pnlByCh.Controls.Add(btnNext);
            pnlByCh.Controls.Add(label2);
            pnlByCh.Controls.Add(textiBudgi);
            pnlByCh.Location = new Point(172, 77);
            pnlByCh.Margin = new Padding(2);
            pnlByCh.Name = "pnlByCh";
            pnlByCh.Size = new Size(451, 226);
            pnlByCh.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // trcDur
            // 
            trcDur.Location = new Point(125, 118);
            trcDur.Maximum = 15;
            trcDur.Minimum = 1;
            trcDur.Name = "trcDur";
            trcDur.Size = new Size(104, 45);
            trcDur.TabIndex = 6;
            trcDur.Value = 1;
            trcDur.Scroll += trcDur_Scroll;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(2, 188);
            btnPrev.Margin = new Padding(2);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(108, 29);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Duration";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(321, 188);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Budget";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            textiBudgi.Location = new Point(111, 40);
            textiBudgi.Margin = new Padding(2);
            textiBudgi.Name = "textiBudgi";
            textiBudgi.Size = new Size(173, 23);
            textiBudgi.TabIndex = 0;
            // 
            // pnlByChoiceNxt
            // 
            pnlByChoiceNxt.Controls.Add(btnPrev2);
            pnlByChoiceNxt.Controls.Add(label4);
            pnlByChoiceNxt.Controls.Add(btnNxt2);
            pnlByChoiceNxt.Controls.Add(label5);
            pnlByChoiceNxt.Controls.Add(textBox2);
            pnlByChoiceNxt.Controls.Add(chEntertainment);
            pnlByChoiceNxt.Controls.Add(chSport);
            pnlByChoiceNxt.Controls.Add(chCulture);
            pnlByChoiceNxt.Controls.Add(cmbCulture);
            pnlByChoiceNxt.Controls.Add(cmbSport);
            pnlByChoiceNxt.Controls.Add(cmbEntertainment);
            pnlByChoiceNxt.Location = new Point(170, 79);
            pnlByChoiceNxt.Margin = new Padding(2);
            pnlByChoiceNxt.Name = "pnlByChoiceNxt";
            pnlByChoiceNxt.Size = new Size(451, 226);
            pnlByChoiceNxt.TabIndex = 8;
            // 
            // btnPrev2
            // 
            btnPrev2.Location = new Point(2, 188);
            btnPrev2.Margin = new Padding(2);
            btnPrev2.Name = "btnPrev2";
            btnPrev2.Size = new Size(108, 29);
            btnPrev2.TabIndex = 5;
            btnPrev2.Text = "Previous";
            btnPrev2.UseVisualStyleBackColor = true;
            btnPrev2.Click += btnPrev2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Reason";
            // 
            // btnNxt2
            // 
            btnNxt2.Location = new Point(321, 188);
            btnNxt2.Margin = new Padding(2);
            btnNxt2.Name = "btnNxt2";
            btnNxt2.Size = new Size(108, 29);
            btnNxt2.TabIndex = 2;
            btnNxt2.Text = "Next";
            btnNxt2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Weather";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 40);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 0;
            // 
            // chEntertainment
            // 
            chEntertainment.AutoSize = true;
            chEntertainment.Location = new Point(219, 116);
            chEntertainment.Name = "chEntertainment";
            chEntertainment.Size = new Size(101, 19);
            chEntertainment.TabIndex = 10;
            chEntertainment.Text = "Entertainment";
            chEntertainment.UseVisualStyleBackColor = true;
            chEntertainment.CheckedChanged += chEntertainment_CheckedChanged;
            // 
            // chSport
            // 
            chSport.AutoSize = true;
            chSport.Location = new Point(139, 117);
            chSport.Name = "chSport";
            chSport.Size = new Size(54, 19);
            chSport.TabIndex = 9;
            chSport.Text = "Sport";
            chSport.UseVisualStyleBackColor = true;
            chSport.CheckedChanged += chSport_CheckedChanged;
            // 
            // chCulture
            // 
            chCulture.AutoSize = true;
            chCulture.Location = new Point(45, 116);
            chCulture.Name = "chCulture";
            chCulture.Size = new Size(65, 19);
            chCulture.TabIndex = 8;
            chCulture.Text = "Culture";
            chCulture.UseVisualStyleBackColor = true;
            chCulture.CheckedChanged += chCulture_CheckedChanged;
            // 
            // cmbCulture
            // 
            cmbCulture.FormattingEnabled = true;
            cmbCulture.Location = new Point(43, 141);
            cmbCulture.Name = "cmbCulture";
            cmbCulture.Size = new Size(67, 23);
            cmbCulture.Sorted = true;
            cmbCulture.TabIndex = 11;
            cmbCulture.Visible = false;
            // 
            // cmbSport
            // 
            cmbSport.FormattingEnabled = true;
            cmbSport.Location = new Point(139, 141);
            cmbSport.Name = "cmbSport";
            cmbSport.Size = new Size(54, 23);
            cmbSport.TabIndex = 12;
            cmbSport.Visible = false;
            // 
            // cmbEntertainment
            // 
            cmbEntertainment.FormattingEnabled = true;
            cmbEntertainment.Location = new Point(219, 141);
            cmbEntertainment.Name = "cmbEntertainment";
            cmbEntertainment.Size = new Size(101, 23);
            cmbEntertainment.TabIndex = 13;
            cmbEntertainment.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1095, 630);
            Controls.Add(pnlMenu);
            Controls.Add(label1);
            Controls.Add(sidePanel);
            Controls.Add(pnlByCh);
            Controls.Add(pnlByChoiceNxt);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconProfile).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlByCh.ResumeLayout(false);
            pnlByCh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trcDur).EndInit();
            pnlByChoiceNxt.ResumeLayout(false);
            pnlByChoiceNxt.PerformLayout();
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
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button btnRandom;
        private Button btnCompare;
        private Panel pnlMenu;
        private Panel pnlByCh;
        private Label label2;
        private TextBox textiBudgi;
        private Button btnNext;
        private Label label3;
        private Button btnPrev;
        private Panel pnlByChoiceNxt;
        private Button btnPrev2;
        private Label label4;
        private Button btnNxt2;
        private Label label5;
        private TextBox textBox2;
        private CheckBox chEntertainment;
        private CheckBox chSport;
        private CheckBox chCulture;
        private ComboBox cmbEntertainment;
        private ComboBox cmbSport;
        private ComboBox cmbCulture;
        private TrackBar trcDur;
        private TextBox textBox1;
    }
}