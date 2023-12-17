using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ITEC_104_Project.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project.Controls
{
    public partial class ucProject : UserControl
    {
        private const string ColumnName = "Title";
        private List<Dictionary<string, object>> tasksList;
        private DataTable taskDataTable = new DataTable();
        private bool isFormatting = false;

        public ucProject()
        {
            InitializeComponent();
            data.CellFormatting += data_CellFormatting;

            tasksList = new List<Dictionary<string, object>>();
            InitializeDataTable();

            data.DataSource = taskDataTable;
            data.DataBindingComplete += data_DataBindingComplete;
        }

        private void InitializeDataTable()
        {
            taskDataTable.Columns.Add("Title", typeof(string));
            taskDataTable.Columns.Add("Status", typeof(string));
            taskDataTable.Columns.Add("Start Date", typeof(DateTime));
            taskDataTable.Columns.Add("End Date", typeof(DateTime));
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createTaskForm taskForm = Application.OpenForms.OfType<createTaskForm>().FirstOrDefault();

            if (taskForm == null)
            {
                taskForm = new createTaskForm();
                taskForm.TasksList = tasksList;
                taskForm.FormClosed += (s, args) => { /* Handle form closed event if needed */ };
                taskForm.ShowDialog();
            }

            taskForm.TasksList = tasksList;
            taskForm.ShowDialog();

            if (taskForm.DialogResult == DialogResult.OK)
            {
                string Title = taskForm.titleTextbox.Text;
                string status = taskForm.statusOption.SelectedItem?.ToString() ?? string.Empty;
                DateTime startDate = taskForm.startDateTimePicker.Value;
                DateTime endDate = taskForm.endDateTimePicker.Value;

                var taskDict = new Dictionary<string, object>
                {
                    { "Title", Title },
                    { "Status", status },
                    { "Start Date", startDate },
                    { "End Date", endDate }
                };

                tasksList.Add(taskDict);

                DataRow newRow = taskDataTable.NewRow();
                newRow["Title"] = Title;
                newRow["Status"] = status;
                newRow["Start Date"] = startDate;
                newRow["End Date"] = endDate;

                taskDataTable.Rows.Add(newRow);
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
                DataGridViewTextBoxColumn? daysPassedColumn = data.Columns["Days Passed"] as DataGridViewTextBoxColumn;

                if (daysPassedColumn == null)
                {
                    daysPassedColumn = new DataGridViewTextBoxColumn();
                    daysPassedColumn.Name = "Days Passed";
                    daysPassedColumn.HeaderText = "Days Passed";
                    data.Columns.Add(daysPassedColumn);
                }

                DataGridViewTextBoxColumn? progressColumn = data.Columns["Progress"] as DataGridViewTextBoxColumn;

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

                        if (totalDays > 0)
                        {
                            TimeSpan daysPassedSpan = currentDate - startDate;
                            int daysPassed = (int)daysPassedSpan.TotalDays;

                            row.Cells["Days Passed"].Value = $"{daysPassed}/{totalDays}";

                            int progressPercentage = (int)((double)daysPassed / totalDays * 100);

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
                string? statusValue = e.Value?.ToString() ?? string.Empty;

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

                    default:
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
            Console.WriteLine("Search button clicked.");

            string searchTerm = srchTXTBox.Text.Trim();

            Console.WriteLine($"Search term: {searchTerm}");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var filteredRows = taskDataTable.AsEnumerable()
                    .Where(row =>
                    {
                        DataRow row1 = row;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        return row1.Field<string>(ColumnName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    })
                    .CopyToDataTable();

                data.DataSource = filteredRows;

                Console.WriteLine("DataSource set to filtered rows.");
            }
            else
            {
                data.DataSource = taskDataTable;

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
                        DataRowView? selectedDataRowView = data.Rows[rowIndex].DataBoundItem as DataRowView;

                        if (selectedDataRowView != null && selectedDataRowView.Row != null)
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
            // Add your edit logic here if needed
        }
    }
}
