using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_104_Project
{
    public partial class RegistrationForm : KryptonForm
    {
        private readonly string connectionString = @"Data Source=DESKTOP-5N7C8KQ\SQLEXPRESS;Initial Catalog=you;Integrated Security=True";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin ff = new FormLogin();
            ff.Show();
            this.Hide();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtbox.Text;
            string password = confirmpasstxtbox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the user with the provided email already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM LoginForm WHERE email = @username";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username);

                        int existingUserCount = (int)checkUserCmd.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("User with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert the new user into the database
                    string insertUserQuery = "INSERT INTO LoginForm (email, password) VALUES (@username, @password)";
                    using (SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, conn))
                    {
                        insertUserCmd.Parameters.AddWithValue("@username", username);
                        insertUserCmd.Parameters.AddWithValue("@password", password); // Note: Hash the password in a real-world scenario

                        int rowsAffected = insertUserCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

