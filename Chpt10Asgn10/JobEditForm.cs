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

    // this part of the class is basically like the add job form... no it is exactly the add job form, just with info already passed into it.
    public partial class JobEditForm : Form
    {

        public int JobNumber
        {
            get
            {
                return Convert.ToInt32(JobNum.Text);
            }
            set
            {
                JobNum.Text = value.ToString();
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
        public string TechnName
        {
            get
            {
                return Technician.Text;
            }
            set
            {
                Technician.Text = value.ToString();
            }
        }
        public string DeviceType
        {
            get
            {
                return Type.Text;
            }
            set
            {
                Type.Text = value.ToString();
            }
        }
        public string DeviceSerialNum
        {
            get
            {
                return SerialNum.Text;
            }
            set
            {
                SerialNum.Text = value.ToString();
            }
        }
        public string JobComments
        {
            get
            {
                return Comment.Text;
            }
            set
            {
                Comment.Text = value.ToString();
            }
        }
        public double EstimateJobTime
        {
            get
            {
                return Convert.ToDouble(EstTime.Text);
            }
            set
            {
                EstTime.Text = value.ToString();
            }
        }
        public double ActualJobTime
        {
            get
            {
                if (ActTime.Text == "")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(ActTime.Text);
                }
            }
            set
            {
                ActTime.Text = value.ToString();
            }
        }
        public string JobDueDate
        {
            get
            {
                return DueDate.Text;
            }
            set
            {
                DueDate.Text = value.ToString();
            }
        }
        public double JobPrice
        {
            get
            {
                if (Price.Text == "")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(Price.Text);
                }
            }
            set
            {
                Price.Text = value.ToString();
            }
        }
        public int RushJobType
        {
            get
            {
                if (RushJobChecker.Checked)
                {
                    RushJobChecker.Enabled = false;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value == 1)
                {
                    RushJobChecker.Checked = true;
                    if (RushJobChecker.Checked == true)
                    {
                        RushJobChecker.Enabled = false;
                        Price.Enabled = false;
                    }
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
                else
                {
                    return 0;
                }
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
                else
                {
                    return 0;
                }
            }
            set
            {
                if(value == 1)
                {
                    PaidCheckBox.Checked = true;
                }
                else if (value == 0)
                {
                    PaidCheckBox.Checked = false;
                }
            }
        }


        public JobEditForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            if (CustName.Text == "" ||
                CustPhone.Text == "" ||
                Type.Text == "" ||
                SerialNum.Text == "" ||
                Comment.Text == "" ||
                EstTime.Text == "" ||
                DueDate.Text == ""
                )
            {
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
                if (Type.Text == "")
                {
                    Type.BackColor = Color.Red;
                }
                else
                {
                    Type.BackColor = Color.White;
                }
                if (SerialNum.Text == "")
                {
                    SerialNum.BackColor = Color.Red;
                }
                else
                {
                    SerialNum.BackColor = Color.White;
                }
                if (Comment.Text == "")
                {
                    Comment.BackColor = Color.Red;
                }
                else
                {
                    Comment.BackColor = Color.White;
                }
                if (EstTime.Text == "")
                {
                    EstTime.BackColor = Color.Red;
                }
                else
                {
                    EstTime.BackColor = Color.White;
                }
                if (DueDate.Text == "")
                {
                    DueDate.BackColor = Color.Red;
                }
                else
                {
                    DueDate.BackColor = Color.White;
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
