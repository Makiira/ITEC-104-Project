using System;
using System.Windows.Forms;

namespace ITEC_104_Project.Forms
{
    public partial class createEventForm : Form
    {
        public event EventHandler<string> EventAdded;

        public createEventForm()
        {

            InitializeComponent();

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string eventText = eventTextBox.Text;

            // Raise the EventAdded event and pass the event text
            EventAdded?.Invoke(this, eventText);

            // Close the form
            this.Close();
        }

        private void eventTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}