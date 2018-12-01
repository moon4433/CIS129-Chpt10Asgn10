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
    public partial class AddJobForm : Form
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
    
        public string CustomerName
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
        public string CustomerPhoneNumber
        {
            get
            {
                return CustPhone.Text;
            }
            set
            {
                CustPhone.Text = value.ToString();
            }
        }
        public string TechnicianName
        {
            get
            {
                return txtTechnician.Text;
            }
            set
            {
                txtTechnician.Text = value.ToString();
            }
        }
        public string DeviceType
        {
            get
            {
                return txtDeviceType.Text;
            }
            set
            {
                txtDeviceType.Text = value.ToString();
            }
        }
        public string DeviceSerialNum
        {
            get
            {
                return txtSerialNum.Text;
            }
            set
            {
                txtSerialNum.Text = value.ToString();
            }
        }
        public string JobComments
        {
            get
            {
                return txtComments.Text;
            }
            set
            {
                txtComments.Text = value.ToString();
            }
        }
        public double EstimateJobTime
        {
            get
            {
                return Convert.ToDouble(txtEstTime.Text);
            }
            set
            {
                txtEstTime.Text = value.ToString();
            }
        }
        public double ActualJobTime
        {
            get
            {
                if (txtActTime.Text == "")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(txtActTime.Text);
                }
            }
            set
            {
                txtActTime.Text = value.ToString();
            }
        }
        public string JobDueDate
        {
            get
            {
                return txtDueDate.Text;
            }
            set
            {
                txtDueDate.Text = value.ToString();
            }
        }
        public double JobPrice
        {
            get
            {
                if (txtPrice.Text == "")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(txtPrice.Text);
                }
            }
            set
            {
                txtPrice.Text = value.ToString();
            }
        }
        public int RushJobType
        {
            get
            {
                if (RushJobChecker.Checked)
                {
                    return 1;
                }
                return 0;
            }
            set
            {
                if (value == 1)
                {
                    RushJobChecker.Checked = true;
                }
            }
        }
        public int JobDoneType
        {
            get
            {
                if (DoneCheckBox.Checked)
                {
                    return 1;
                }

                return 0;
            }
            set
            {
                if (value == 1)
                {
                    DoneCheckBox.Checked = true;
                }
            }
        }
        public int JobPaidType
        {
            get
            {
                if (PaidCheckBox.Checked)
                {
                    return 1;
                }
                return 0;
            }
            set
            {
                if(value == 1)
                {
                    PaidCheckBox.Checked = true;
                }
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (txtJobNum.Text == "" ||
                CustName.Text == "" ||
                CustPhone.Text == "" ||
                txtDeviceType.Text == "" ||
                txtSerialNum.Text == "" ||
                txtComments.Text == "" ||
                txtEstTime.Text == "" ||
                txtDueDate.Text == ""
                )
            {
                if (txtJobNum.Text == "")
                {
                    txtJobNum.BackColor = Color.Red;
                }
                else
                {
                    txtJobNum.BackColor = Color.White;
                }
                if (CustName.Text == "")
                {
                    CustName.BackColor = Color.Red;
                }
                else
                {
                    CustName.BackColor = Color.White;
                }
                if (CustPhone.Text == "")
                {
                    CustPhone.BackColor = Color.Red;
                }
                else
                {
                    CustPhone.BackColor = Color.White;
                }
                if (txtDeviceType.Text == "")
                {
                    txtDeviceType.BackColor = Color.Red;
                }
                else
                {
                    txtDeviceType.BackColor = Color.White;
                }
                if (txtSerialNum.Text == "")
                {
                    txtSerialNum.BackColor = Color.Red;
                }
                else
                {
                    txtSerialNum.BackColor = Color.White;
                }
                if (txtComments.Text == "")
                {
                    txtComments.BackColor = Color.Red;
                }
                else
                {
                    txtComments.BackColor = Color.White;
                }
                if (txtEstTime.Text == "")
                {
                    txtEstTime.BackColor = Color.Red;
                }
                else
                {
                    txtEstTime.BackColor = Color.White;
                }
                if (txtDueDate.Text == "")
                {
                    txtDueDate.BackColor = Color.Red;
                }
                else
                {
                    txtDueDate.BackColor = Color.White;
                }

                MessageBox.Show("You are missing some information.");
            }
            else
            {
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
