using System.Reflection;

namespace The_project
{
    public partial class Form1 : Form
    {
        public Form1(string userName)
        {
            InitializeComponent();
            
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
            showLess.Size = new Size(showMore.Size.Width,showMore.Size.Height);
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
            iconProfile.BackColor=Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoiceForm choiceForm = new ChoiceForm();
            choiceForm.ShowDialog();
        }
    }
}