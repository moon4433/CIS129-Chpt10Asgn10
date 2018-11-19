namespace Chpt10Asgn10
{
    partial class JobListApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobListApp));
            this.ExitButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Paid = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActTime = new System.Windows.Forms.TextBox();
            this.EstTime = new System.Windows.Forms.TextBox();
            this.SerialNum = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Technician = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CustPhone = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.JobNumLabel = new System.Windows.Forms.Label();
            this.JobNumberBox = new System.Windows.Forms.TextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.Comment = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(136, 554);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(136, 525);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 525);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(247, 525);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CommentLabel);
            this.groupBox1.Controls.Add(this.Comment);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Paid);
            this.groupBox1.Controls.Add(this.Done);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DueDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ActTime);
            this.groupBox1.Controls.Add(this.EstTime);
            this.groupBox1.Controls.Add(this.SerialNum);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Technician);
            this.groupBox1.Controls.Add(this.PhoneLabel);
            this.groupBox1.Controls.Add(this.CustPhone);
            this.groupBox1.Controls.Add(this.CustNameLabel);
            this.groupBox1.Controls.Add(this.CustName);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 451);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Paid";
            // 
            // Paid
            // 
            this.Paid.BackColor = System.Drawing.SystemColors.Menu;
            this.Paid.Enabled = false;
            this.Paid.Location = new System.Drawing.Point(223, 410);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(49, 20);
            this.Paid.TabIndex = 19;
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.SystemColors.Menu;
            this.Done.Enabled = false;
            this.Done.Location = new System.Drawing.Point(122, 410);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(49, 20);
            this.Done.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Done";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Due Date";
            // 
            // DueDate
            // 
            this.DueDate.BackColor = System.Drawing.SystemColors.Menu;
            this.DueDate.Enabled = false;
            this.DueDate.Location = new System.Drawing.Point(80, 366);
            this.DueDate.Name = "DueDate";
            this.DueDate.ShortcutsEnabled = false;
            this.DueDate.Size = new System.Drawing.Size(192, 20);
            this.DueDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Serial #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Device Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Technician";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time for Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estimated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actual";
            // 
            // ActTime
            // 
            this.ActTime.BackColor = System.Drawing.SystemColors.Menu;
            this.ActTime.Enabled = false;
            this.ActTime.Location = new System.Drawing.Point(221, 330);
            this.ActTime.Name = "ActTime";
            this.ActTime.Size = new System.Drawing.Size(51, 20);
            this.ActTime.TabIndex = 8;
            // 
            // EstTime
            // 
            this.EstTime.BackColor = System.Drawing.SystemColors.Menu;
            this.EstTime.Enabled = false;
            this.EstTime.Location = new System.Drawing.Point(122, 330);
            this.EstTime.Name = "EstTime";
            this.EstTime.Size = new System.Drawing.Size(50, 20);
            this.EstTime.TabIndex = 7;
            // 
            // SerialNum
            // 
            this.SerialNum.BackColor = System.Drawing.SystemColors.Menu;
            this.SerialNum.Enabled = false;
            this.SerialNum.Location = new System.Drawing.Point(80, 128);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(192, 20);
            this.SerialNum.TabIndex = 6;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.SystemColors.Menu;
            this.Type.Enabled = false;
            this.Type.Location = new System.Drawing.Point(80, 102);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(192, 20);
            this.Type.TabIndex = 5;
            // 
            // Technician
            // 
            this.Technician.BackColor = System.Drawing.SystemColors.Menu;
            this.Technician.Enabled = false;
            this.Technician.Location = new System.Drawing.Point(80, 76);
            this.Technician.Name = "Technician";
            this.Technician.Size = new System.Drawing.Size(192, 20);
            this.Technician.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(31, 53);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(48, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone #";
            // 
            // CustPhone
            // 
            this.CustPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.CustPhone.Enabled = false;
            this.CustPhone.Location = new System.Drawing.Point(80, 50);
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.Size = new System.Drawing.Size(192, 20);
            this.CustPhone.TabIndex = 2;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Location = new System.Drawing.Point(44, 27);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CustNameLabel.TabIndex = 1;
            this.CustNameLabel.Text = "Name";
            // 
            // CustName
            // 
            this.CustName.BackColor = System.Drawing.SystemColors.Menu;
            this.CustName.Enabled = false;
            this.CustName.Location = new System.Drawing.Point(80, 24);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(192, 20);
            this.CustName.TabIndex = 0;
            // 
            // JobNumLabel
            // 
            this.JobNumLabel.AutoSize = true;
            this.JobNumLabel.Location = new System.Drawing.Point(10, 10);
            this.JobNumLabel.Name = "JobNumLabel";
            this.JobNumLabel.Size = new System.Drawing.Size(64, 13);
            this.JobNumLabel.TabIndex = 6;
            this.JobNumLabel.Text = "Job Number";
            // 
            // JobNumberBox
            // 
            this.JobNumberBox.Location = new System.Drawing.Point(13, 26);
            this.JobNumberBox.Name = "JobNumberBox";
            this.JobNumberBox.Size = new System.Drawing.Size(100, 20);
            this.JobNumberBox.TabIndex = 7;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(140, 24);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 8;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.SystemColors.Menu;
            this.Comment.Enabled = false;
            this.Comment.Location = new System.Drawing.Point(80, 154);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(192, 146);
            this.Comment.TabIndex = 0;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(23, 222);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(56, 13);
            this.CommentLabel.TabIndex = 21;
            this.CommentLabel.Text = "Comments";
            // 
            // JobListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 585);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.JobNumberBox);
            this.Controls.Add(this.JobNumLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JobListApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job List Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label JobNumLabel;
        private System.Windows.Forms.TextBox JobNumberBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.TextBox CustPhone;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.TextBox Done;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ActTime;
        private System.Windows.Forms.TextBox EstTime;
        private System.Windows.Forms.TextBox SerialNum;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Technician;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Paid;
        private System.Windows.Forms.Label CommentLabel;
    }
}

