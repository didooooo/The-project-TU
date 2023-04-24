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
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string userName=random.Next().ToString();
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
    }
}
