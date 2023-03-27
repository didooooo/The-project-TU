using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    }
}
