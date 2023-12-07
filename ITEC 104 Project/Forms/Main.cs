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
using System.Data.SqlClient;

namespace ITEC_104_Project
{
    public partial class Main : KryptonForm
    {
        Controls.Control1 MainDashboard = new Controls.Control1();
        Controls.Control2 Dashboard2 = new Controls.Control2();
        Controls.Control3 Dashboard3 = new Controls.Control3();
        Controls.Control4 Dashboard4 = new Controls.Control4();

        public Main()
        {
            InitializeComponent();
            CollapseMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(MainDashboard);
            MainDashboard.Dock = DockStyle.Fill;
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.Menu.Width > 200)
            {
                Menu.Width = 100;
                menuButton.Dock = DockStyle.Top;
                foreach (Button menuButton in Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding();
                }
            }
            else
            {
                Menu.Width = 230;
                menuButton.Dock = DockStyle.None;
                foreach (Button menuButton in Menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(MainDashboard);
            MainDashboard.Dock = DockStyle.Fill;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Dashboard2);
            Dashboard2.Dock = DockStyle.Fill;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Dashboard3);
            Dashboard3.Dock = DockStyle.Fill;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Dashboard4);
            Dashboard4.Dock = DockStyle.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

