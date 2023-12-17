using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace ITEC_104_Project.Controls
{
    public partial class ucCalendar : UserControl
    {

        Calendar cal = new Calendar();
        public ucCalendar() => InitializeComponent();

        private void Control3_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(cal);
            panel2.Dock = DockStyle.Fill;
        }
    }
}
