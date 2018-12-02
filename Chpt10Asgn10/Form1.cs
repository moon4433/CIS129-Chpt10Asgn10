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


           /**
             *  Job Order List
             *  Keegan Johnson
             *  12-1-18
             *  CIS 129
             *  Chapter 10 Assignment 10
             *  This program will allow the user to add, edit, view, and delete jobs. This essentally ment to help keep track and organize the 
             *  jobs that a phone repair comany would have...
             * 
             */

        /**  this partial class holds everything done on the first form  **/
    public partial class JobListApp : Form
    {
        public ArrayList jobs = new ArrayList(); // this array is to hold any job objects created throughout the application
        public Job currentJob; // this job object is to hold the current job that is called
        public Job rushJob; // this job object is to replace the current job and turn it into a rushed job object


        // this method is to create the first form application and initialize all its components 
        public JobListApp()
        {
            InitializeComponent();
        }

        // this method handles when the exit button is pressed, and closes the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // this method is to handle when the add button is pressed and add a new job to the job arraylist
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddJobForm ajForm = new AddJobForm(); // adding a new addjobform object to this button(behind the scenes)
            DialogResult result = ajForm.ShowDialog(); // creates a new dialog result object named result and adds if OK was pressed in addjobform
            if (result == DialogResult.OK) // if OK was pressed
            {
                try // catch if user does something wrong
                {

                    Job newJob = new Job(ajForm.JobNum, ajForm.CustomerName, ajForm.CustomerPhoneNumber, // adds all the info from the addjobform to the newjob object
                        ajForm.TechnicianName, ajForm.DeviceType, ajForm.DeviceSerialNum, ajForm.JobComments,
                        ajForm.EstimateJobTime, ajForm.ActualJobTime, ajForm.JobDueDate, ajForm.JobPrice,
                        ajForm.RushJobType, ajForm.JobDoneType, ajForm.JobPaidType);

                    if (ajForm.RushJobType == 1) // if rush job was checked
                    {
                        Job rushJob = new Job(newJob); // creates a new rush job object from the new job object
                        jobs.Add(rushJob); //adds the rush job to the array list
                        rushJob.isRushJob = true; // tells the program that the object is a rush job
                    }
                    else // if not a rush job
                    {
                        jobs.Add(newJob); // this adds the new job to the array list
                    }
                }
                catch // this is the catch for if the user does anything wrong
                {
                    MessageBox.Show("Please enter the correct information\nthe correct fields");
                }
            }
        }


        // this method is to handle if the edit button is pressed
        private void EditButton_Click(object sender, EventArgs e)
        {


            if (JobNumberBox.Text == "") // if the number box is empty
            {
                MessageBox.Show("Please enter a valid job number");
            }
            else if (jobs.Count == 0) // if the array list count is 0, meaning that there isnt anything in it
            {
                MessageBox.Show("There are currently no jobs to edit at this time.");
            }
            else // if all checks have been met
            {
                try // this is the catch for if the user enters anything wrong
                {

                    int jobNum = Convert.ToInt32(JobNumberBox.Text); // this converts the number that the user enters to an int
                    JobEditForm ejForm = new JobEditForm(); // this object is to hold a JobEditForm object

                    foreach (Job job in jobs) // this foreach loop loops through the jobs array list
                    {
                        if (job.JobNum == jobNum) // if the job number that the user entered matches the job number from a job in the array list
                        {

                            currentJob = job; // that job is the current job

                        }
                        
                        // these make the ejForms obj variables to match the current jobs
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
                            try // if user enters any info that doesnt match its variable this is the catch
                            {
                                //if user changed anything, this adds it to the current job
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

                                if (ejForm.RushJobType == 1) // if the job was promoted to a rush job
                                {
                                    if (currentJob.isRushJob == false) // and if it already wasn't given its promotion perks
                                    {
                                        Job rushJob = new Job(currentJob); // makes the current job into a rushed job
                                        rushJob.RushJobType = ejForm.RushJobType; // makes the current rush job type into rushed, this is just for the form and check marks
                                        jobs.Remove(currentJob); // removes the current job from the array list
                                        jobs.Add(rushJob); // and replaces it with the rushed job, which is basically the same job just with rushed perks
                                        rushJob.isRushJob = true; // this is to tell program that current job has recieved promotion perks
                                    }
                                    currentJob.RushJobType = ejForm.RushJobType;
                                    currentJob.JobPrice = ejForm.JobPrice;
                                }
                                else
                                {
                                    currentJob.RushJobType = ejForm.RushJobType;
                                    currentJob.JobPrice = ejForm.JobPrice;
                                }

                                currentJob.JobDoneType = ejForm.JobDoneType;
                                currentJob.JobPaidType = ejForm.JobPaidType;

                                break; // there should only be one item since each job has a unique number, so there is no need to loop more than once
                            }
                            catch // the catch
                            {
                                MessageBox.Show("Please enter the correct information\nthe correct fields");
                            }

                        }
                    }
                }
                catch // another catch
                {
                    MessageBox.Show("Please enter a valid job number.");
                }
            }

        }

        // this method handles if the delete button was pressed
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

        // this method is to handle if the view button was pressed
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


    // this class is to handle the creation of job objects and whether or not they are rush job objects or normal jobs
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
