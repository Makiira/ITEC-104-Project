using ITEC_104_Project.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ITEC_104_Project
{
    public partial class Calendar : UserControl
    {
        int month, year;

        public Calendar()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
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

        private void calendarNextButton_Click(object sender, EventArgs e)
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

        private void calendarPrevButton_Click(object sender, EventArgs e)
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

        private void ShowEventForm()
        {
            createEventForm eventForm = new createEventForm();
            eventForm.EventAdded += EventForm_EventAdded;
            eventForm.ShowDialog();
        }

        private void EventForm_EventAdded(object sender, string eventText)
        {
            AddEventToPanel(eventText);
        }

        private void AddEventToPanel(string eventText)
        {
            ucDays ucd = new ucDays();
            ucd.DisplayEventText(eventText);
            daycontainer.Controls.Add(ucd);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
