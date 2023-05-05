using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace The_project
{
    public partial class Form1 : Form
    {
        public Form1(string userName)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Size = new Size(1024, 720);
            this.BackColor = Color.FromArgb(20, 69, 82);
            sidePanel.BackColor = Color.FromArgb(27, 58, 75);
            showMore.BackColor = Color.FromArgb(27, 58, 75);
            btnExit.Location = new Point(62, Bottom);
            labelName.Text = userName;
            labelName.ForeColor = Color.White;
            // topPanel.BackColor = Color.FromArgb(20, 69, 83);
            //akop iskash da dobavish nov button po vreme na izpylnenie na programata i realno da mu dobavish eventa
            this.showLess.Click += new EventHandler(this.showLess_Click);
            // this.Cursor += new EventHandler(this.cursorChange_Mouse);
            // this.Size = new Size(int.MaxValue-1000, int.MaxValue-1000);
        }

        

        Button showLess = new Button();

        private void showMore_Click(object sender, EventArgs e)
        {
            sidePanel.Size = new Size(300, Bottom);
            showMore.Hide();
            showLess.Show();
            showLess.Size = new Size(showMore.Size.Width, showMore.Size.Height);
            labelName.Location = new Point(82, 102);
            showLess.Location = new Point(6, 12);
            showLess.FlatStyle = FlatStyle.Flat;
            showLess.FlatAppearance.BorderSize = 0;
            showLess.BackgroundImageLayout = ImageLayout.Zoom;
            showLess.BackgroundImage = showMore.BackgroundImage;
            iconProfile.Location = new Point(62, 12);
            sidePanel.Controls.Add(showLess);
            btnDashboard.Text = "Dashboard";
            btnFavourite.Text = "Favourites";
            btnContactUs.Text = "Contact Us";
            btnReviews.Text = "Reviews";
            btnExit.Text = "Exit";
            btnDashboard.Size = new Size(190, 40);
            btnContactUs.Size = new Size(190, 40);
            btnReviews.Size = new Size(190, 40);
            btnExit.Size = new Size(190, 40);
            btnFavourite.Size = new Size(190, 40);
        }
        private void showLess_Click(object sender, EventArgs e)
        {
            sidePanel.Size = new Size(214, Bottom);
            iconProfile.Location = new Point(62, 12);
            labelName.Location = new Point(42, 102);
            btnDashboard.Text = "";
            btnContactUs.Text = "";
            btnFavourite.Text = "";
            btnReviews.Text = "";
            btnExit.Text = "";
            btnDashboard.Size = new Size(51, 55);
            btnFavourite.Size = new Size(51, 55);
            btnReviews.Size = new Size(51, 55);
            btnContactUs.Size = new Size(51, 55);
            btnExit.Size = new Size(51, 55);
            showLess.Hide();
            showMore.Show();

        }

        private void iconProfile_Click(object sender, EventArgs e)
        {
            iconProfile.BackColor = Color.Transparent;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            pnlRandom.Show();
            pnlMenu.Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
        }

        private void btnBackG_Click(object sender, EventArgs e)
        {
            pnlMenu.Show();
            pnlRandom.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your destination is ");
            pnlRandom.Hide();
            pnlMenu.Show();
        }

        private void btnComparee_Click(object sender, EventArgs e)
        {
            combOneC.Location = new Point(118, 43);
            combSecondC.Location = new Point(479, 43);
            btnComparee.Location = new Point(284, 482);
            dataOneC.Visible = true;
            dataSecondC.Visible = true;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            pnlCompare.Visible = true;
            pnlMenu.Visible = false;
        }

        private void btnBackC_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlCompare.Visible = false;
            combOneC.Location = new Point(118, 207);
            combSecondC.Location = new Point(479, 207);
            btnComparee.Location = new Point(284, 318);
            dataOneC.Visible = false;
            dataSecondC.Visible = false;
        }

        private void pnlByCh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxBudget.Text = trackBarBudget.Value.ToString();
            textBoxBudget.Text += " lv";
            textBoxDays.Text = trackBarDays.Value.ToString();
            if (trackBarDays.Value.ToString() == "1")
            {
                textBoxDays.Text += " day";
            }
            else
            {
                textBoxDays.Text += " days";
            }
            if (radioButtonWarm.Checked == true)
            {
                checkBoxSports.Text = "Skiing/Snowboarding";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Show();
            pnlByCh.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlByChoice2.Visible = true;
            pnlByCh.Visible = false;
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlContactUs.Visible = true;
            pnlMenu.Hide();
            pnlContactUs.Show();
            txtBoxSubject.PlaceholderText = "Subject";

        }


        private void btnBackToMenuContactUs_Click(object sender, EventArgs e)
        {
            pnlContactUs.Visible = false;
            pnlContactUs.Hide();
            pnlMenu.Show();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email has been sent.");
            txtBoxSubject.Clear();
            txtboxEmail.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenu.Hide();
            pnlByCh.Visible = true;
        }

        private void btnBackToMenuSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlMenu.Visible = true;
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlSearch.Visible = true;
            pictureBoxSearch.Visible = true;
            pictureBoxSearchSecondImage.Visible = true;
            pictureBoxSearchThirdImage.Visible = true;
            Graphics g = Graphics.FromHwnd(pictureBoxSearch.Handle);
            imgList.Images.Add(Image.FromFile(@"C:\Users\dimit\OneDrive\Работен плот\Durjavi\Bulgaria.png"));
            imgList.Images.Add(Image.FromFile(@"C:\Users\dimit\OneDrive\Работен плот\Durjavi\Finland.png"));
            imgList.Images.Add(Image.FromFile(@"C:\Users\dimit\OneDrive\Работен плот\Durjavi\Greece.png"));
            imgList.ImageSize = new Size(380, 380);
            pictureBoxSearch.Image = imgList.Images[0];
            pictureBoxSearchSecondImage.Image = imgList.Images[1];
            pictureBoxSearchThirdImage.Image= imgList.Images[2];
        }

        private void btnSearchinSearch_Click(object sender, EventArgs e)
        {
            pictureBoxSearch.Visible = false;
            pictureBoxSearchSecondImage.Visible = false;
            pictureBoxSearchThirdImage.Visible = false;
        }
    }
}