using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIRAManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text== "" && textBoxPassword.Text== "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "password")
            {
                 Employees employees = new Employees();
                employees.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the correct password");
            }
        }
    }
}
