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
    public partial class Activities : Form
    {
        private int rollId;
        //constructor
        public Activities(int roleId)
        {
            InitializeComponent();
            rollId = roleId;
        }
        public Activities()
        {
            InitializeComponent();
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            if (rollId == 2)
            {
                labelEmployees.Visible = false;
                labelProjects.Visible = false;
                labelActivities.Visible = false;
            }
        }
    }
}
