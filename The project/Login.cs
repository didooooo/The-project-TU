using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            signUpPanel.Visible = false;
            loginPanel.Visible = false;
            signUpPanel.BackColor = Color.FromArgb(27, 58, 75);
            loginPanel.BackColor = Color.FromArgb(27, 58, 75);
            pnlChoose.BackColor = Color.FromArgb(27, 58, 75);
            this.ForeColor = Color.White;
            this.Size = new Size(1024, 720);
            this.BackColor = Color.FromArgb(20, 69, 82);
            list = File.ReadAllLines(path).ToList();
            listP = File.ReadAllLines(pathP).ToList();
            listEmails = File.ReadAllLines(pathEmails).ToList();
        }
        List<string> list = new List<string>();
        List<string> listP = new List<string>();
        List<string> listEmails = new List<string>();
        string path = @"C:\Users\dimit\OneDrive\Работен плот\project\The-project-TU\Username.txt";
        string pathP = @"C:\Users\dimit\OneDrive\Работен плот\project/The-project-TU\passwords.txt";
        string pathEmails = @"C:\Users\dimit\OneDrive\Работен плот\project/The-project-TU\emails.txt";
        private void btnGuest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string userName = random.Next().ToString();
            Form1 homeForm = new Form1("guest " + userName);
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
        private void signUpLabel_Click(object sender, EventArgs e)
        {
            signUpPanel.Show();
            loginPanel.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlChoose.Hide();
            loginPanel.Show();
        }

        private void lloginLabel_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            signUpPanel.Hide();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (textBoxpasswordL.Text != "" && textBoxemailL.Text != "")
            {
                String recentUsername = textBoxemailL.Text;
                String recentPassword = textBoxpasswordL.Text;
                bool flag = false;
                if (list.Count != 0)
                {
                    foreach (String x in list)
                    {
                        if ((recentUsername.Equals(x)))
                        {
                            flag = true;
                        }
                    }
                    foreach (String x in listP)
                    {
                        if ((recentPassword.Equals(x)))
                        {
                            flag = true;

                        }
                    }
                    if (flag)
                    {
                        Form1 homeForm = new Form1("Hello " + recentUsername);
                        this.Hide();
                        homeForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There is no such account");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    

        private void btnSignUpinSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text != "" && textBoxemailS.Text != "" && textBoxpasswordS.Text != "" && textBoxSName.Text != "")
            {
                if (String.Equals(textBoxpasswordS.Text, textBoxConfirmPass.Text))
                {

                    bool flag = true;
                    bool flagE = true;
                    if ((textBoxemailS.Text).Contains("@gmail.com"))
                    {
                        foreach (String x in list)
                        {
                            if ((x.Equals(textBoxSName.Text)))
                            {
                                flag = false;
                            }
                        }
                        foreach (String x in listEmails)
                        {
                            if ((x.Equals(textBoxemailS.Text)))
                            {
                                flagE = false;
                            }
                        }
                        if (flagE == false)
                        {
                            MessageBox.Show("Already has an account registered with this email");
                        }
                        else if (flag == false)
                        {
                            MessageBox.Show("There is already user with this name");
                        }
                        else
                        {
                            list.Add(textBoxSName.Text);
                            listP.Add(textBoxpasswordS.Text);
                            listEmails.Add(textBoxemailS.Text);
                            File.WriteAllLines(path, list);
                            File.WriteAllLines(pathEmails, listEmails);
                            File.WriteAllLines(pathP, listP);
                            Form1 homeForm = new Form1("Hello " + textBoxSName.Text);
                            this.Hide();
                            homeForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid email");
                    }
                }
                else
                {
                    MessageBox.Show("The passwords do not match!");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
