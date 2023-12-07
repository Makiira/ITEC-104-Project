using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ITEC_104_Project
{
    public partial class FormLogin : KryptonForm
    {
        private readonly string connectionString = @"Data Source=DESKTOP-5N7C8KQ\SQLEXPRESS;Initial Catalog=you;Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            string username = emailTxtBox.Text;
            string password = passTxtBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM LoginForm WHERE email = @username AND password = @password";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@username", username);
                        sda.SelectCommand.Parameters.AddWithValue("@password", password);

                        DataTable dataTable = new DataTable();
                        sda.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Successful login
                            Main f = new Main();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Invalid login credentials
                            MessageBox.Show("Invalid login details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            emailTxtBox.Clear();
                            passTxtBox.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
