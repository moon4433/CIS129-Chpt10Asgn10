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
                Job newJob = new Job(ajForm.JobNum,ajForm.CustomerName,ajForm.CustomerPhoneNumber,
                    ajForm.TechnicianName, ajForm.DeviceType, ajForm.DeviceSerialNum, ajForm.JobComments,
                    ajForm.EstimateJobTime, ajForm.ActualJobTime, ajForm.JobDueDate, ajForm.JobPrice,
                    ajForm.RushJobType, ajForm.JobDoneType, ajForm.JobPaidType);
                jobs.Add(newJob);
            }
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {

            JobEditForm ejForm = new JobEditForm();
            ejForm.ShowDialog();
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            int jobNum = Convert.ToInt32(JobNumberBox.Text);

            foreach (Job job in jobs)
            {
                if(job.JobNum == jobNum)
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
                Price.Text = Convert.ToString(currentJob.JobPrice);
                if(currentJob.RushJobType == 1)
                {
                    RushJobChecker.CheckState = CheckState.Checked;
                }
                if(currentJob.JobDoneType == 1)
                {
                    DoneCheckBox.CheckState = CheckState.Checked;
                }
                if(currentJob.JobPaidType == 1)
                {
                    PaidCheckBox.CheckState = CheckState.Checked;
                }
                


            }
        }
    }



    public partial class Job: Form
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
    }
}
