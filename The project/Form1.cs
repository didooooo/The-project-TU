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
            lblMoneyT.Visible = false;
            lblMoneyS.Visible = false;
            lblMoneyO.Visible = false;
            
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
                    lblMoneyO.Visible = true;
                    lblMoneyT.Visible = true;
                    lblMoneyO.Text = prices[combOneC.SelectedIndex].ToString() +" lv per day.";
                    lblMoneyT.Text = prices[combSecondC.SelectedIndex].ToString()+ " lv per day";
                }
                else
                {
                    lblOneC.Visible = false;
                    lblSecondC.Visible = false;
                    lblMoneyO.Visible = false;
                    lblMoneyT.Visible = false;
                    lblIfEquals.Visible = true;
                    lblMoneyS.Visible = true;
                    lblIfEquals.Text = dataForCountry[combOneC.SelectedIndex].ToString();
                    lblMoneyS.Text = prices[combOneC.SelectedIndex].ToString() + " lv per day.";
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
            if (radioButtonCold.Checked == true)
            {
                checkBoxSports.Text = "Skiing/Snowboarding";
            }else if(radioButtonWarm.Checked == true)
            {
                checkBoxSports.Text = "Swimming/Surfing";
            }else if (radioButtonDoesntMatter.Checked == true)
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
            lblMoneyO.Visible = false;
            lblMoneyS.Visible = false;
            lblMoneyT.Visible = false;
            index = 0;
            indexCold = 0;
            indexWarm = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevChoice_Click(object sender, EventArgs e)
        {
            pnlByChoice2.Visible=false;
            pnlByCh.Visible = true;
            indexCold = 0;
            index = 0;
            indexWarm = 0;
        }
        int indexWarm = 0, indexCold = 0, index = 0;

        private void btnSendReview_Click(object sender, EventArgs e)
        {
           
            reviews.Add(textBoxReview.Text + '\n' + labelName.Text.ToString());
            File.WriteAllLines(pathReviews, reviews);
            MessageBox.Show("The review has been send");
            textBoxReview.Clear();
            lblReviewO.Text = reviews[0].ToString();
           
        }
        int valueTimer = 0;
        private void timerReviews_Tick(object sender, EventArgs e)
        {
            valueTimer++;
            try
            {
                Random random = new Random();
                if (reviews.Count >= 1)
                {
                    int number = random.Next(0, reviews.Count - 1);
                    lblReviewO.Visible = true;
                    lblReviewS.Visible = true;
                    if (valueTimer % 100 == 0 || valueTimer == 1)
                    {
                        lblReviewO.Text = reviews[number];
                        lblReviewS.Text = reviews[number + 1];
                    }
                }
                else
                {

                    lblReviewO.Visible = true;
                    lblReviewO.Text = "no reviews yet";

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            pnlReviews.Visible=true;
            pnlMenu.Visible=false;
            timerReviews.Start();
           
        }

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
                                        ". The money that you need are " + (days * prices[i]).ToString()+" lv.");
                                    break;
                                }
                                else
                                {
                                    indexCold++;
                                    MessageBox.Show("The perfect country is " + nameCountry[i].ToString() + "! You can go to the " + mountainOrSea[i].ToString() +
                                        ". The money that you need are " + (days * prices[i]).ToString()+ "lv.");
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
                    btnDashboard_Click(sender,e);
                }
            }
        }
    }
}