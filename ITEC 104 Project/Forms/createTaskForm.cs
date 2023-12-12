using System;
using System.Data;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project.Forms
{
    public partial class createTaskForm : KryptonForm
    {
        public DataTable? TaskDataTable
        {
            get { return taskDataTable; }
            set { taskDataTable = value; }
        }

        private DataTable? taskDataTable;
        private int rowIndex = -1;

        public createTaskForm()
        {
            InitializeComponent();
        }

        public void LoadTaskData(int index)
        {
            if (index >= 0 && index < taskDataTable?.Rows.Count)
            {
                rowIndex = index;
                titleTextbox.Text = taskDataTable.Rows[index]["Title"].ToString();
                statusOption.SelectedItem = taskDataTable.Rows[index]["Status"].ToString();
                startDateTimePicker.Value = (DateTime)taskDataTable.Rows[index]["Start Date"];
                endDateTimePicker.Value = (DateTime)taskDataTable.Rows[index]["End Date"];
            }
        }

        private void ctfAddBtn_Click(object sender, EventArgs e)
        {
            // Validate input before adding a new row
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

            try
            {
                // Validate the date range
                DateTime startDate = startDateTimePicker.Value;
                DateTime endDate = endDateTimePicker.Value;

                if (endDate < startDate)
                {
                    MessageBox.Show("End date must be later than start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rowIndex != -1)
                {
                    // Editing existing row
                    DataRow editedRow = taskDataTable?.Rows[rowIndex] ?? throw new InvalidOperationException("TaskDataTable cannot be null.");
                    editedRow["Title"] = titleTextbox.Text;
                    editedRow["Status"] = statusOption.SelectedItem?.ToString() ?? "DefaultStatus";
                    editedRow["Start Date"] = startDate;
                    editedRow["End Date"] = endDate;
                }
                else
                {
                    // Adding new row
                    DataRow newRow = taskDataTable?.NewRow() ?? throw new InvalidOperationException("TaskDataTable cannot be null.");
                    newRow["Title"] = titleTextbox.Text;
                    newRow["Status"] = statusOption.SelectedItem?.ToString() ?? "DefaultStatus";
                    newRow["Start Date"] = startDate;
                    newRow["End Date"] = endDate;

                    taskDataTable?.Rows.Add(newRow);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
