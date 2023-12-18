using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project
{
    public partial class FormLogin : KryptonForm
    {

        public FormLogin() => InitializeComponent();
        private void loginButton1_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void extiButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
