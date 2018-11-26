using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chpt10Asgn10
{
    public partial class JobListApp : Form
    {
        public ArrayList jobs = new ArrayList();
        
        

        public JobListApp()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddJobForm ajForm = new AddJobForm();
            ajForm.ShowDialog();
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            AddJobForm ajForm = new AddJobForm();
            ajForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
