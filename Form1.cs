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

namespace JIRAManagementSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // pllaintext

                conn.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    // Login successful
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    var Activities = new Activities(); 
                    Activities.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
}
