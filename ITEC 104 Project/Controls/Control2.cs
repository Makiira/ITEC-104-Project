using ITEC_104_Project.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project.Controls
{
    public partial class Control2 : UserControl
    {
        private DataTable DataTaskTable;
        private bool isFormatting = false;

        public DataTable taskDataTable
        {
            get { return DataTaskTable; }
            set { DataTaskTable = value; }
        }

        public Control2()
        {
            InitializeComponent();
            data.CellFormatting += data_CellFormatting;

            taskDataTable = new DataTable();
            taskDataTable.Columns.Add("Title", typeof(string));
            taskDataTable.Columns.Add("Status", typeof(string));
            taskDataTable.Columns.Add("Start Date", typeof(DateTime));
            taskDataTable.Columns.Add("End Date", typeof(DateTime));

            DataTaskTable = taskDataTable; // Initialize DataTaskTable here

            data.DataSource = taskDataTable;
            data.DataBindingComplete += data_DataBindingComplete;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createTaskForm taskForm = Application.OpenForms.OfType<createTaskForm>().FirstOrDefault();

            if (taskForm == null)
            {
                taskForm = new createTaskForm();
                taskForm.TaskDataTable = taskDataTable;
                taskForm.FormClosed += (s, args) => { /* Handle form closed event if needed */ };
                taskForm.ShowDialog();
            }

            taskForm.TaskDataTable = taskDataTable;
            taskForm.ShowDialog();

            if (taskForm.DialogResult == DialogResult.OK)
            {
                if (data.DataSource is DataTable dt)
                {
                    string Title = taskForm.titleTextbox.Text;
                    string status = taskForm.statusOption.SelectedItem?.ToString() ?? string.Empty;
                    DateTime startDate = taskForm.startDateTimePicker.Value;
                    DateTime endDate = taskForm.endDateTimePicker.Value;

                    DataRow newRow = dt.NewRow();
                    newRow["Title"] = Title;
                    newRow["Status"] = status;
                    newRow["Start Date"] = startDate;
                    newRow["End Date"] = endDate;

                    dt.Rows.Add(newRow);
                }
            }
        }

        private void data_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (isFormatting)
            {
                return;
            }

            isFormatting = true;

            try
            {
                DataGridViewTextBoxColumn daysPassedColumn = data.Columns["Days Passed"] as DataGridViewTextBoxColumn;

                if (daysPassedColumn == null)
                {
                    daysPassedColumn = new DataGridViewTextBoxColumn();
                    daysPassedColumn.Name = "Days Passed";
                    daysPassedColumn.HeaderText = "Days Passed";
                    data.Columns.Add(daysPassedColumn);
                }

                DataGridViewTextBoxColumn progressColumn = data.Columns["Progress"] as DataGridViewTextBoxColumn;

                if (progressColumn == null)
                {
                    progressColumn = new DataGridViewTextBoxColumn();
                    progressColumn.Name = "Progress";
                    progressColumn.HeaderText = "Progress";
                    data.Columns.Add(progressColumn);
                }

                foreach (DataGridViewRow row in data.Rows)
                {
                    if (row.Cells["End Date"].Value != null && row.Cells["Start Date"].Value != null)
                    {
                        DateTime endDate = (DateTime)row.Cells["End Date"].Value;
                        DateTime startDate = (DateTime)row.Cells["Start Date"].Value;
                        DateTime currentDate = DateTime.Now;

                        TimeSpan duration = endDate - startDate;
                        int totalDays = (int)duration.TotalDays;

                        // Check if totalDays is zero to avoid division by zero
                        if (totalDays > 0)
                        {
                            TimeSpan daysPassedSpan = currentDate - startDate;
                            int daysPassed = (int)daysPassedSpan.TotalDays;

                            row.Cells["Days Passed"].Value = $"{daysPassed}/{totalDays}";

                            // Calculate progress percentage
                            int progressPercentage = (int)((double)daysPassed / totalDays * 100);

                            // Set progress bar value as a string
                            row.Cells["Progress"].Value = $"{progressPercentage}%";
                        }
                        else
                        {
                            row.Cells["Days Passed"].Value = "N/A";
                            row.Cells["Progress"].Value = "N/A";
                        }
                    }
                }
            }
            finally
            {
                isFormatting = false;
            }
        }

        private void data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (isFormatting || e.RowIndex < 0 || e.ColumnIndex != data.Columns["Status"].Index)
            {
                return;
            }

            isFormatting = true;

            try
            {
                string? statusValue = e.Value?.ToString(); // Use '?' for nullability

                // Customize cell appearance based on the status
                switch (statusValue)
                {
                    case "Low Priority":
                        e.CellStyle.BackColor = Color.Orange;
                        break;

                    case "Medium Priority":
                        e.CellStyle.BackColor = Color.Red;
                        break;

                    case "High Priority":
                        e.CellStyle.BackColor = Color.Green;
                        break;

                    // Add more cases for other status values if needed

                    default:
                        // Reset to default cell style
                        e.CellStyle.BackColor = data.DefaultCellStyle.BackColor;
                        break;
                }
            }
            finally
            {
                isFormatting = false;
            }
        }

        private void srchBTN_Click(object sender, EventArgs e)
        {
            // Add a debug statement to check if the method is being called
            Console.WriteLine("Search button clicked.");

            string searchTerm = srchTXTBox.Text.Trim();

            // Add a debug statement to check the value of searchTerm
            Console.WriteLine($"Search term: {searchTerm}");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var filteredRows = taskDataTable.AsEnumerable()
                    .Where(row => row.Field<string>("Title").Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .CopyToDataTable();

                data.DataSource = filteredRows;

                // Add a debug statement to check if the DataSource was set correctly
                Console.WriteLine("DataSource set to filtered rows.");
            }
            else
            {
                data.DataSource = taskDataTable;

                // Add a debug statement to check if the DataSource was set to the original data
                Console.WriteLine("DataSource set to original data.");
            }
        }
        private void deleteSelectedRows()
        {
            if (data.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<int> selectedIndices = new List<int>();

                    foreach (DataGridViewRow selectedRow in data.SelectedRows)
                    {
                        selectedIndices.Add(selectedRow.Index);
                    }

                    for (int i = selectedIndices.Count - 1; i >= 0; i--)
                    {
                        int rowIndex = selectedIndices[i];
                        DataRowView selectedDataRowView = data.Rows[rowIndex].DataBoundItem as DataRowView;

                        if (selectedDataRowView != null)
                        {
                            DataRow selectedDataRow = selectedDataRowView.Row;
                            taskDataTable.Rows.Remove(selectedDataRow);
                        }
                    }

                    data.ClearSelection();
                    data.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void delBTN_Click(object sender, EventArgs e)
        {
            deleteSelectedRows();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {

        }
    }
}