using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project.Forms
{
    public partial class createTaskForm : Form
    {
        private List<Dictionary<string, object>>? tasksList;
        private int rowIndex = -1;

        public createTaskForm()
        {
            InitializeComponent();
        }

        public List<Dictionary<string, object>>? TasksList
        {
            get { return tasksList; }
            set { tasksList = value; }
        }

        public void LoadTaskData(int index)
        {
            if (index >= 0 && index < tasksList?.Count)
            {
                rowIndex = index;
                titleTextbox.Text = tasksList[index]["Title"].ToString();
                statusOption.SelectedItem = tasksList[index]["Status"].ToString();
                startDateTimePicker.Value = (DateTime)tasksList[index]["Start Date"];
                endDateTimePicker.Value = (DateTime)tasksList[index]["End Date"];
            }
        }

        private void ctfAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(titleTextbox.Text))
                {
                    MessageBox.Show("Please enter a valid title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (statusOption.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime startDate = startDateTimePicker.Value;
                DateTime endDate = endDateTimePicker.Value;

                if (endDate < startDate)
                {
                    MessageBox.Show("End date must be later than start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rowIndex != -1)
                {
                    Dictionary<string, object> editedTask = tasksList?[rowIndex] ?? throw new InvalidOperationException("TasksList cannot be null.");
                    editedTask["Title"] = titleTextbox.Text;
                    editedTask["Status"] = statusOption.SelectedItem?.ToString() ?? "DefaultStatus";
                    editedTask["Start Date"] = startDate;
                    editedTask["End Date"] = endDate;
                }
                else
                {
                    var taskDict = new Dictionary<string, object>
                    {
                        { "Title", titleTextbox.Text },
                        { "Status", statusOption.SelectedItem?.ToString() ?? "DefaultStatus" },
                        { "Start Date", startDate },
                        { "End Date", endDate }
                    };

                    tasksList?.Add(taskDict);
                }

                // Log statements for debugging
                Console.WriteLine("Setting DialogResult to OK");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Log statements for debugging
                Console.WriteLine("Closing the form");
                this.Close();
            }
        }
    }
}
