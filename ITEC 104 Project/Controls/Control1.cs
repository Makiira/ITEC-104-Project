using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_104_Project.Controls
{
    public partial class Control1 : UserControl
    {
        Calendar cal = new Calendar();
        public Control1()
        {
            InitializeComponent();
        }
        private void Control1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(cal);
        }
    }
}
