using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project
{
    public partial class FormLogin : KryptonForm
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            if (emailTxtBox.Text == "0322-1415@lspu.edu.ph")
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unknown Email Account");
                emailTxtBox.Clear();
            }
        }

        private void loginButton1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {

        }
    }
}
