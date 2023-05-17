using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Intrinsics.X86;
using System.Numerics;
using System;

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
            //akop iskash da dobavish nov button po vreme na izpylnenie na programata i realno da mu dobavish eventa
            string path = @"C:\Users\dimit\OneDrive\Работен плот\project\The-project-TU\dataForCountry.txt";
            dataForCountry = File.ReadAllLines(path).ToArray();
            reviews = File.ReadAllLines(pathReview).ToList();
            //imageForCountry=File.ReadAllLines(pathImage).ToArray();
            imageForCountry = Directory.GetFiles(@"C:\Users\dimit\OneDrive\Работен плот\Durjavi", "*.png");
        }
        string pathReview = @"C:\Users\dimit\OneDrive\Работен плот\project\The-project-TU\reviews.txt";
        List<string> reviews = new List<string>();
        String[] dataForCountry = new String[21];
        String[] imageForCountry = new String[21];
        String[] nameCountry = {"Austria","Bulgaria", "Czechia","England", "Finland","France" ,"Germany", "Greece","Ireland",
                                "Italy","Macedonia",
                                "Poland", "Portugal","Romania","Serbia", "Slovakia","Spain","Switzerland","Turkey","Ukraine" };
        int[] prices = {130,85,122,173,124,156,164,93,146,129,79,113,99,103,82,119,134,143,65,69};
        String[] activities = { "swimming","snowboard","skiing","surfing","skiing","snowboard",
            "skiing","swimming","surfing","skiing","skiing","hiking","surfing","snowboard","skiing",
            "skiing","skiing","skiing","swimming","swimming" };
        String[] mountainOrSea = { "both","both","mountain","mountain","mountain","sea","nmountain",
            "sea","mountain","sea","mountain","mountain","mountain","mountain","mountain","mountain",
                "both"," mountain","sea","mountain" };
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
            pictureBoxForSeacrhedCountry.Visible = false;
            lblSearchedCountry.Visible = false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            pnlMenu.Visible = false;
            lblSearch.Visible = true;
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
           
            String searchedCountry = textBoxSearch.Text.ToString();
            int flag = 0;
            for(int i = 0; i < nameCountry.Length; i++)
            {
                if(searchedCountry.ToLower() == nameCountry[i].ToLower())
                {
                    pictureBoxSearch.Visible = false;
                    pictureBoxSearchSecondImage.Visible = false;
                    pictureBoxSearchThirdImage.Visible = false;
                    lblSearch.Visible = false;
                    lblSearchedCountry.Visible = true;
                    pictureBoxForSeacrhedCountry.Visible = true;
                    lblSearchedCountry.Text = dataForCountry[i];
                    Image img;
                    img = Image.FromFile(imageForCountry[i]);
                    pictureBoxForSeacrhedCountry.Image = img;
                    flag = 1;
                    textBoxSearch.Clear();
                }
            }
            if(flag== 0)
            {
                MessageBox.Show("There is no such country in our database");
                textBoxSearch.Clear();
            }
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlRandom.Visible = false;
            pnlSearch.Visible = false;
            pnlCompare.Visible = false;
            pnlByCh.Visible = false;
            pnlByChoice2.Visible = false;
            pnlContactUs.Visible = true;
            pnlMenu.Hide();
            pnlReviews.Visible = false;
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
            btnAccept.Visible = false;
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
            btnAccept.Visible = true;
        }
        int randomAll = 0;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
            Random random = new Random();
            int number=random.Next(0,20);
            randomAll = number;
            lblRandom.Text = dataForCountry[number].ToString();
            lblRandom.Visible = true;
            pictureBoxArrow.Visible = false;
            pictureBoxImageRandom.Visible = true;
            try
            {
                Image img;
                img = Image.FromFile(imageForCountry[number]);
                pictureBoxImageRandom.Image=img;
            }
            catch (Exception)
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your destination is " + nameCountry[randomAll] );
            pnlRandom.Hide();
            lblRandom.Visible = false;
            pictureBoxArrow.Visible=true;
            pictureBoxImageRandom.Visible = false;
            pnlMenu.Show();
        }

        private void btnBackC_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlCompare.Visible = false;
            combOneC.Location = new Point(118, 207);
            combSecondC.Location = new Point(479, 207);
            btnComparee.Location = new Point(284, 318);
            lblOneC.Visible = false;
            lblSecondC.Visible = false;
            lblIfEquals.Visible = false;
            
        }

        private void btnComparee_Click(object sender, EventArgs e)
        {
            if (combOneC.SelectedIndex >= 0 && combSecondC.SelectedIndex >= 0)
            {
                combOneC.Location = new Point(118, 43);
                combSecondC.Location = new Point(479, 43);
                btnComparee.Location = new Point(284, 482);
                if (combOneC.SelectedIndex != combSecondC.SelectedIndex)
                {
                    lblOneC.Visible = true;
                    lblSecondC.Visible = true;
                    lblIfEquals.Visible = false;
                    lblOneC.Text = dataForCountry[combOneC.SelectedIndex].ToString();
                    lblSecondC.Text = dataForCountry[combSecondC.SelectedIndex].ToString();
                }
                else
                {
                    lblOneC.Visible = false;
                    lblSecondC.Visible = false;
                    lblIfEquals.Visible = true;
                    lblIfEquals.Text = dataForCountry[combOneC.SelectedIndex].ToString();
                }
            }
            else
            {
                MessageBox.Show("Choose country!");
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
            else if (radioButtonWarm.Checked == true)
            {
                checkBoxSports.Text = "Swimming/Surfing";
            }
            else if (radioButtonDoesntMatter.Checked == true)
            {
                checkBoxSports.Text = "Sports activities";
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
                {
                    break;
                }
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
            pnlReviews.Visible = false;
            pnlByCh.Hide();
            pnlByChoice2.Hide();
            pnlCompare.Hide();
            pnlContactUs.Hide();
            pnlMenu.Hide();
            pnlRandom.Hide();
            pnlSearch.Hide();
            pnlMenu.Visible = true;
            pictureBoxArrow.Visible = true;
            pictureBoxImageRandom.Visible = false;
            lblRandom.Visible = false;
            btnAccept.Visible = false;
            lblSearchedCountry.Visible = false;
            pictureBoxForSeacrhedCountry.Visible = false;
            pnlMenu.Visible = true;
            pnlCompare.Visible = false;
            combOneC.Location = new Point(118, 207);
            combSecondC.Location = new Point(479, 207);
            btnComparee.Location = new Point(284, 318);
            lblOneC.Visible = false;
            lblSecondC.Visible = false;
            lblIfEquals.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            pnlRandom.Visible = false;
            pnlSearch.Visible = false;
            pnlCompare.Visible = false;
            pnlByCh.Visible = false;
            pnlByChoice2.Visible = false;
            pnlContactUs.Visible = false;
            pnlMenu.Visible = false;
            pnlReviews.Visible = true;
            timerR.Start();

        }

        private void btnSendReview_Click(object sender, EventArgs e)
        {
            if (textBoxReview.Text != "")
            {
                reviews.Add("\"" + textBoxReview.Text + "\" - " + labelName.Text.ToString());
                File.WriteAllLines(pathReview, reviews);
                MessageBox.Show("Email has been send");
                textBoxReview.Clear();
            }
            else
            {
                MessageBox.Show("It can not be empty!");
            }
             
        }
        int val = 0;
        private void timerR_Tick(object sender, EventArgs e)
        {
            try
            {
                val++;
                if (val % 100 == 0 || val == 1)
                {
                    Random random = new Random();
                    int number = random.Next(0, reviews.Count - 1);
                    lblREview.Text = reviews[number].ToString();
                }
            }
            catch (Exception)
            {

            }
        }
        int index = 0, indexWarm = 0,indexCold=0;
        private void btnFinish_Click(object sender, EventArgs e)
        {
            int budget = trackBarBudget.Value;
            int days = trackBarDays.Value;
            String wheather;
            if (radioButtonCold.Checked == true)
            {
                wheather = radioButtonCold.Text.ToString();
                if (indexCold < 20)
                {
                    for (int i = indexCold; i < 20; i++)
                    {
                        if (activities[i].Equals("snowboard") || activities[i].Equals("skiing"))
                        {
                            if (days * prices[i] <= budget)
                            {
                                if (mountainOrSea[i] == "both")
                                {
                                    indexCold++;
                                    MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the sea or to the mounatin" +
                                        ". The money that you need are " + (days * prices[i]).ToString() + " lv.");
                                    break;
                                }
                                else
                                {
                                    indexCold++;
                                    MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the " + mountainOrSea[i].ToString() +
                                        ". The money that you need are " + (days * prices[i]).ToString() + "lv.");
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    btnDashboard_Click(sender, e);

                }
            }
            else if (radioButtonWarm.Checked)
            {
                wheather = radioButtonWarm.Text.ToString();
                if (indexWarm < 20)
                {
                    for (int i = indexWarm; i < 20; i++)
                    {
                        if (activities[i] == "swimming" || activities[i] == "surfing")
                        {
                            if (days * prices[i] <= budget)
                            {
                                if (mountainOrSea[i] == "both")
                                {
                                    indexWarm++;
                                    MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the sea or to the mounatin" +
                                        ". The money that you need are " + (days * prices[i]).ToString() + "lv.");
                                    break;
                                }
                                else
                                {
                                    indexWarm++;
                                    MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the " + mountainOrSea[i].ToString() +
                                        ". The money that you need are " + (days * prices[i]).ToString() + "lv.");

                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    btnDashboard_Click(sender, e);

                }

            }
            else if (radioButtonDoesntMatter.Checked)
            {
                wheather = radioButtonDoesntMatter.Text.ToString();
                if (index < 20)
                {
                    for (int i = index; i < 20; i++)
                    {
                        if (days * prices[i] <= budget)
                        {
                            if (mountainOrSea[i] == "both")
                            {
                                index++;
                                MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the sea or to the mounatin" +
                                    ". The money that you need are " + (days * prices[i]).ToString() + "lv.");

                                break;
                            }
                            else
                            {
                                index++;
                                MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the " + mountainOrSea[i].ToString() +
                                    ". The money that you need are " + (days * prices[i]).ToString() + "lv.");

                                break;
                            }
                        }
                    }
                }
                else
                {
                    btnDashboard_Click(sender, e);
                }
            }
        }
    }
}