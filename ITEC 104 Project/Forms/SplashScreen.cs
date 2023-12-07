using Krypton.Toolkit;
using System.Data.SqlClient;
namespace ITEC_104_Project
{
    public partial class splashScreen : KryptonForm
    {
        public splashScreen()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progress.Value = start;
            if (progress.Value == 80)
            {
                progress.Value = 0;
                timer1.Stop();
                FormLogin f = new FormLogin();
                this.Hide();
                f.Show();
            }
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
        private void splashScreen_Load(object sender, EventArgs e)
        {
          
        } */
    }
}