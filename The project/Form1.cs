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
            btnExit.Location = new Point(62, Bottom);
            labelName.Text = userName;
            labelName.ForeColor = Color.White;
            // topPanel.BackColor = Color.FromArgb(20, 69, 83);
            //akop iskash da dobavish nov button po vreme na izpylnenie na programata i realno da mu dobavish eventa
            // this.Cursor += new EventHandler(this.cursorChange_Mouse);
            // this.Size = new Size(int.MaxValue-1000, int.MaxValue-1000);
        }



        Button showLess = new Button();



        private void iconProfile_Click(object sender, EventArgs e)
        {
            iconProfile.BackColor = Color.Transparent;
        }







        private void pnlByCh_Paint(object sender, PaintEventArgs e)
        {

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
            pictureBoxSearchThirdImage.Image = imgList.Images[2];
        }

        private void btnSearchinSearch_Click(object sender, EventArgs e)
        {
            pictureBoxSearch.Visible = false;
            pictureBoxSearchSecondImage.Visible = false;
            pictureBoxSearchThirdImage.Visible = false;
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlContactUs.Visible = true;
            pnlMenu.Hide();
            pnlContactUs.Show();
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            pnlRandom.Show();
            pnlMenu.Hide();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            pnlCompare.Visible = true;
            pnlMenu.Visible = false;
        }

        private void btnBackG_Click(object sender, EventArgs e)
        {
            pnlMenu.Show();
            pnlRandom.Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your destination is ");
            pnlRandom.Hide();
            pnlMenu.Show();
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

        private void btnComparee_Click(object sender, EventArgs e)
        {
            combOneC.Location = new Point(118, 43);
            combSecondC.Location = new Point(479, 43);
            btnComparee.Location = new Point(284, 482);
            dataOneC.Visible = true;
            dataSecondC.Visible = true;
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

        private void textBoxBudget_TextChanged(object sender, EventArgs e)
        {
           
                String temp = "";
            for (int i = 0; i < textBoxBudget.Text.Length; i++)
            {
                if (textBoxBudget.Text[i] == 'l')
                    break;
                else
                {
                    temp += textBoxBudget.Text[i];
                }
            }
                try
                {
                if (int.Parse(temp) > 2000)
                {
                    MessageBox.Show("The max is 2000 lv!");
                    trackBarBudget.Value = 2000;
                }
                    trackBarBudget.Value = int.Parse(temp);
                }
                catch (Exception)
                {

                }

        }

        private void textBoxDays_TextChanged(object sender, EventArgs e)
        {

            String temp = "";
            for (int i = 0; i < textBoxDays.Text.Length; i++)
            {
                if (textBoxDays.Text[i] == 'd')
                    break;
                else temp += textBoxDays.Text[i];
            }
            try
            {
                if (int.Parse(temp) > 30)
                {
                    MessageBox.Show("The max is 30 days!");
                    trackBarDays.Value = 30;
                }
                trackBarDays.Value = int.Parse(temp);
            }
            catch (Exception)
            {

            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        { 
            pnlByCh.Hide();
            pnlByChoice2.Hide();
            pnlCompare.Hide();
            pnlContactUs.Hide();
            pnlMenu.Hide();
            pnlRandom.Hide();
            pnlSearch.Hide();
            pnlMenu.Visible = true; ;
        }
    }
}