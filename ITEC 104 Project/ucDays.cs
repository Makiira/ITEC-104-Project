using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_104_Project
{
    public partial class ucDays : UserControl
    {
        public ucDays()
        {
            InitializeComponent();
        }

        private void ucDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays)
        {
            lbDays.Text = numdays + "";
        }
    }
}
