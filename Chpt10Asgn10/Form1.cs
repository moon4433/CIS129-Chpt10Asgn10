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
        public Job currentJob;
        public Job rushJob;



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
            DialogResult result = ajForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {

                    Job newJob = new Job(ajForm.JobNum, ajForm.CustomerName, ajForm.CustomerPhoneNumber,
                        ajForm.TechnicianName, ajForm.DeviceType, ajForm.DeviceSerialNum, ajForm.JobComments,
                        ajForm.EstimateJobTime, ajForm.ActualJobTime, ajForm.JobDueDate, ajForm.JobPrice,
                        ajForm.RushJobType, ajForm.JobDoneType, ajForm.JobPaidType);
                    
                    if (ajForm.RushJobType == 1)
                    {
                            Job rushJob = new Job(newJob);
                            jobs.Add(rushJob);
                            rushJob.isRushJob = true;  
                    }
                    else
                    {
                        jobs.Add(newJob);
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter the correct information\nthe correct fields");
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {


            if (JobNumberBox.Text == "")
            {
                MessageBox.Show("Please enter a valid job number");
            }
            else if (jobs.Count == 0)
            {
                MessageBox.Show("There are currently no jobs to edit at this time.");
            }
            else
            {
                try
                {

                    int jobNum = Convert.ToInt32(JobNumberBox.Text);

                    foreach (Job job in jobs)
                    {
                        if (job.JobNum == jobNum)
                        {

                            currentJob = job;

                        }
                        JobEditForm ejForm = new JobEditForm();

                        ejForm.JobNumber = currentJob.JobNum;
                        ejForm.CustomerName = currentJob.CustomerName;
                        ejForm.CustomerPhoneNumber = currentJob.CustomerPhoneNumber;
                        ejForm.TechnName = currentJob.TechnicianName;
                        ejForm.DeviceType = currentJob.DeviceType;
                        ejForm.DeviceSerialNum = currentJob.DeviceSerialNum;
                        ejForm.JobComments = currentJob.JobComments;
                        ejForm.EstimateJobTime = currentJob.EstimateJobTime;
                        ejForm.ActualJobTime = currentJob.ActualJobTime;
                        ejForm.JobDueDate = currentJob.JobDueDate;
                        ejForm.JobPrice = currentJob.JobPrice;
                        if (currentJob.RushJobType == 1)
                        {
                            ejForm.RushJobType = 1;
                        }
                        if (currentJob.JobDoneType == 1)
                        {
                            ejForm.JobDoneType = 1;
                        }
                        if (currentJob.JobPaidType == 1)
                        {

                            ejForm.JobPaidType = 1;
                        }

                        DialogResult result = ejForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                currentJob.JobNum = ejForm.JobNumber;
                                currentJob.CustomerName = ejForm.CustomerName;
                                currentJob.CustomerPhoneNumber = ejForm.CustomerPhoneNumber;
                                currentJob.TechnicianName = ejForm.TechnName;
                                currentJob.DeviceType = ejForm.DeviceType;
                                currentJob.DeviceSerialNum = ejForm.DeviceSerialNum;
                                currentJob.JobComments = ejForm.JobComments;
                                currentJob.EstimateJobTime = ejForm.EstimateJobTime;
                                currentJob.ActualJobTime = ejForm.ActualJobTime;
                                currentJob.JobDueDate = ejForm.JobDueDate;
                                currentJob.RushJobType = ejForm.RushJobType;
                                if (currentJob.RushJobType == 1)
                                {
                                    if (currentJob.isRushJob == false)
                                    {
                                        Job rushJob = new Job(currentJob);
                                        jobs.Add(rushJob);
                                        rushJob.isRushJob = true;


                                    }
                                    else
                                    {
                                        currentJob.JobPrice = ejForm.JobPrice;
                                    }
                                }

                                currentJob.JobDoneType = ejForm.JobDoneType;
                                currentJob.JobPaidType = ejForm.JobPaidType;
                            }
                            catch
                            {
                                MessageBox.Show("Please enter the correct information\nthe correct fields");
                            }

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid job number.");
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (JobNumberBox.Text == "")
            {
                MessageBox.Show("Please enter a valid job number.");
            }
            else if (jobs.Count == 0)
            {
                MessageBox.Show("There are currently no jobs to delete at this time.");
            }
            else
            {
                try
                {
                    int jobNum = Convert.ToInt32(JobNumberBox.Text);

                    foreach (Job job in jobs)
                    {
                        if (job.JobNum == jobNum)
                        {

                            currentJob = job;

                        }

                        if (MessageBox.Show("Are you sure?", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                        {

                            jobs.Remove(currentJob);
                            jobs.Remove(rushJob);
                            JobNumberBox.Text = null;
                            CustName.Text = null;
                            CustPhone.Text = null;
                            Technician.Text = null;
                            Type.Text = null;
                            SerialNum.Text = null;
                            Comment.Text = null;
                            EstTime.Text = null;
                            ActTime.Text = null;
                            DueDate.Text = null;
                            Price.Text = null;
                            RushJobChecker.CheckState = CheckState.Unchecked;
                            DoneCheckBox.CheckState = CheckState.Unchecked;
                            PaidCheckBox.CheckState = CheckState.Unchecked;

                            break;
                        }


                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid job number.");
                }
            }

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                int jobNum = Convert.ToInt32(JobNumberBox.Text);

                if (jobs.Count == 0)
                {
                    MessageBox.Show("There are currently no jobs to view at this time.");
                }
                else
                {
                    foreach (Job job in jobs)
                    {


                        if (job.JobNum == jobNum)
                        {

                            currentJob = job;

                        }


                        CustName.Text = currentJob.CustomerName;
                        CustPhone.Text = currentJob.CustomerPhoneNumber;
                        Technician.Text = currentJob.TechnicianName;
                        Type.Text = currentJob.DeviceType;
                        SerialNum.Text = currentJob.DeviceSerialNum;
                        Comment.Text = currentJob.JobComments;
                        EstTime.Text = Convert.ToString(currentJob.EstimateJobTime);
                        ActTime.Text = Convert.ToString(currentJob.ActualJobTime);
                        DueDate.Text = currentJob.JobDueDate;
                        Price.Text = ("$" + Convert.ToString(currentJob.JobPrice));
                        if (currentJob.RushJobType == 1)
                        {

                            RushJobChecker.CheckState = CheckState.Checked;

                        }
                        else if (currentJob.RushJobType == 0)
                        {
                            RushJobChecker.CheckState = CheckState.Unchecked;
                        }
                        if (currentJob.JobDoneType == 1)
                        {
                            DoneCheckBox.CheckState = CheckState.Checked;
                        }
                        else if (currentJob.JobDoneType == 0)
                        {
                            DoneCheckBox.CheckState = CheckState.Unchecked;
                        }
                        if (currentJob.JobPaidType == 1)
                        {
                            PaidCheckBox.CheckState = CheckState.Checked;
                        }
                        else if (currentJob.JobPaidType == 0)
                        {
                            PaidCheckBox.CheckState = CheckState.Unchecked;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid job number");
            }






        }
    }



    public partial class Job : Form
    {
        public Job(int Number, string Name, string Phone, string Technician, string Device, string SerialNum,
            string Comments, double EstTime, double ActTime, string DueDate, double Price, int JobType, int Done,
            int Paid)
        {
            this.JobNum = Number;
            this.CustomerName = Name;
            this.CustomerPhoneNumber = Phone;
            this.TechnicianName = Technician;
            this.DeviceType = Device;
            this.DeviceSerialNum = SerialNum;
            this.JobComments = Comments;
            this.EstimateJobTime = EstTime;
            this.ActualJobTime = ActTime;
            this.JobDueDate = DueDate;
            this.JobPrice = Price;
            this.RushJobType = JobType;
            this.JobDoneType = Done;
            this.JobPaidType = Paid;
        }
        public Job(Job currentJob)
        {

            this.JobNum = currentJob.JobNum;
            this.CustomerName = currentJob.CustomerName;
            this.CustomerPhoneNumber = currentJob.CustomerPhoneNumber;
            this.TechnicianName = currentJob.TechnicianName;
            this.DeviceType = currentJob.DeviceType;
            this.DeviceSerialNum = currentJob.DeviceSerialNum;
            this.JobComments = currentJob.JobComments;
            this.EstimateJobTime = currentJob.EstimateJobTime;
            this.ActualJobTime = currentJob.ActualJobTime;
            this.JobDueDate = currentJob.JobDueDate;
            this.JobPrice = currentJob.JobPrice + (currentJob.JobPrice * .15);
            this.RushJobType = currentJob.RushJobType;
            this.JobDoneType = currentJob.JobDoneType;
            this.JobPaidType = currentJob.JobPaidType;



        }

        public int JobNum { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string TechnicianName { get; set; }
        public string DeviceType { get; set; }
        public string DeviceSerialNum { get; set; }
        public string JobComments { get; set; }
        public double EstimateJobTime { get; set; }
        public double ActualJobTime { get; set; }
        public string JobDueDate { get; set; }
        public double JobPrice { get; set; }
        public int RushJobType { get; set; }
        public int JobDoneType { get; set; }
        public int JobPaidType { get; set; }
        public bool isRushJob = false;
    }

}
