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
    public partial class Control3 : UserControl
    {
        int month, year;
        public Control3()
        {
            InitializeComponent();
        }

        private void Control3_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;  // Corrected
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucBlank uc = new ucBlank();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                ucDays ucd = new ucDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd);
            }
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucBlank uc = new ucBlank();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                ucDays ucd = new ucDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd);
            }
        }

        private void lbdate_Click(object sender, EventArgs e)
        {

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                ucBlank uc = new ucBlank();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                ucDays ucd = new ucDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
