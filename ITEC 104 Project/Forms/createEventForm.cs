using System;
using System.Windows.Forms;

namespace ITEC_104_Project.Forms
{
    public partial class createEventForm : Form
    {
        public event EventHandler<Dictionary<string, string>> EventAdded;

        public createEventForm()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string eventText = eventTextBox.Text;

            // Create a dictionary to hold the event information
            Dictionary<string, string> eventData = new Dictionary<string, string>
            {
                { "EventText", eventText }
                // Add more key-value pairs for additional information if needed
            };

            // Raise the EventAdded event and pass the event data
            EventAdded?.Invoke(this, eventData);

            // Close the form
            this.Close();
        }

        private void eventTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}