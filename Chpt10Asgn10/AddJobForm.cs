using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chpt10Asgn10
{
    public partial class AddJobForm: Form
    {

        public int JobNum
        {
            get
            {
                return Convert.ToInt32(txtJobNum.Text);
            }
            set
            {
                txtJobNum.Text = value.ToString();
            }
        }

        public string Name
        {
            get
            {
                return CustName.Text;
            }
            set
            {
                CustName.Text = value.ToString();
            }
        }

        public AddJobForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
