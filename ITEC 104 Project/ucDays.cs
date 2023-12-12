using ITEC_104_Project.Forms;
using System;
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

        public void DisplayEventText(string eventText)
        {
            nameLabel.Text = eventText;
        }

        private void ucDays_Click(object sender, EventArgs e)
        {
            ShowEventForm();
        }

        private void ShowEventForm()
        {
            createEventForm cef = new createEventForm();
            cef.EventAdded += Cef_EventAdded;
            cef.ShowDialog();
        }

        private void Cef_EventAdded(object sender, string eventText)
        {
            // Handle the event added here
            // For example, display the event text on the label
            DisplayEventText(eventText);
        }
    }
}
