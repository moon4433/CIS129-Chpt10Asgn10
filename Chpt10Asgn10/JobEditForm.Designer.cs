namespace Chpt10Asgn10
{
    partial class JobEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobEditForm));
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.lable1000 = new System.Windows.Forms.Label();
            this.DoneCheckBox = new System.Windows.Forms.CheckBox();
            this.PaidCheckBox = new System.Windows.Forms.CheckBox();
            this.RushJobChecker = new System.Windows.Forms.CheckBox();
            this.JobNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
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
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(115, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(86, 24);
            this.Title.TabIndex = 15;
            this.Title.Text = "Edit Job";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CommentLabel);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.lable1000);
            this.groupBox1.Controls.Add(this.DoneCheckBox);
            this.groupBox1.Controls.Add(this.PaidCheckBox);
            this.groupBox1.Controls.Add(this.RushJobChecker);
            this.groupBox1.Controls.Add(this.JobNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Comment);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 490);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(0, 253);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(65, 52);
            this.CommentLabel.TabIndex = 34;
            this.CommentLabel.Text = "Problem \r\nDescription/\r\nComments\r\n\r\n";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.Menu;
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(65, 432);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(192, 20);
            this.Price.TabIndex = 33;
            // 
            // lable1000
            // 
            this.lable1000.AutoSize = true;
            this.lable1000.Location = new System.Drawing.Point(26, 432);
            this.lable1000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1000.Name = "lable1000";
            this.lable1000.Size = new System.Drawing.Size(31, 13);
            this.lable1000.TabIndex = 32;
            this.lable1000.Text = "Price";
            // 
            // DoneCheckBox
            // 
            this.DoneCheckBox.AutoSize = true;
            this.DoneCheckBox.Location = new System.Drawing.Point(133, 463);
            this.DoneCheckBox.Name = "DoneCheckBox";
            this.DoneCheckBox.Size = new System.Drawing.Size(52, 17);
            this.DoneCheckBox.TabIndex = 31;
            this.DoneCheckBox.Text = "Done";
            this.DoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaidCheckBox
            // 
            this.PaidCheckBox.AutoSize = true;
            this.PaidCheckBox.Location = new System.Drawing.Point(224, 463);
            this.PaidCheckBox.Name = "PaidCheckBox";
            this.PaidCheckBox.Size = new System.Drawing.Size(47, 17);
            this.PaidCheckBox.TabIndex = 30;
            this.PaidCheckBox.Text = "Paid";
            this.PaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // RushJobChecker
            // 
            this.RushJobChecker.AutoSize = true;
            this.RushJobChecker.Location = new System.Drawing.Point(32, 463);
            this.RushJobChecker.Name = "RushJobChecker";
            this.RushJobChecker.Size = new System.Drawing.Size(71, 17);
            this.RushJobChecker.TabIndex = 29;
            this.RushJobChecker.Text = "Rush Job";
            this.RushJobChecker.UseVisualStyleBackColor = true;
            // 
            // JobNum
            // 
            this.JobNum.BackColor = System.Drawing.SystemColors.Menu;
            this.JobNum.Enabled = false;
            this.JobNum.Location = new System.Drawing.Point(65, 48);
            this.JobNum.Name = "JobNum";
            this.JobNum.ReadOnly = true;
            this.JobNum.Size = new System.Drawing.Size(192, 20);
            this.JobNum.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Job #";
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.SystemColors.Window;
            this.Comment.Location = new System.Drawing.Point(65, 208);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(192, 146);
            this.Comment.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Due Date";
            // 
            // DueDate
            // 
            this.DueDate.BackColor = System.Drawing.SystemColors.Window;
            this.DueDate.Location = new System.Drawing.Point(65, 409);
            this.DueDate.Name = "DueDate";
            this.DueDate.ShortcutsEnabled = false;
            this.DueDate.Size = new System.Drawing.Size(192, 20);
            this.DueDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Serial #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Technician";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time for Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estimated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actual";
            // 
            // ActTime
            // 
            this.ActTime.BackColor = System.Drawing.SystemColors.Window;
            this.ActTime.Location = new System.Drawing.Point(206, 384);
            this.ActTime.Name = "ActTime";
            this.ActTime.Size = new System.Drawing.Size(51, 20);
            this.ActTime.TabIndex = 8;
            // 
            // EstTime
            // 
            this.EstTime.BackColor = System.Drawing.SystemColors.Window;
            this.EstTime.Location = new System.Drawing.Point(107, 384);
            this.EstTime.Name = "EstTime";
            this.EstTime.Size = new System.Drawing.Size(50, 20);
            this.EstTime.TabIndex = 7;
            // 
            // SerialNum
            // 
            this.SerialNum.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNum.Location = new System.Drawing.Point(65, 182);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(192, 20);
            this.SerialNum.TabIndex = 6;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.SystemColors.Window;
            this.Type.Location = new System.Drawing.Point(65, 156);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(192, 20);
            this.Type.TabIndex = 5;
            // 
            // Technician
            // 
            this.Technician.BackColor = System.Drawing.SystemColors.Window;
            this.Technician.Location = new System.Drawing.Point(65, 130);
            this.Technician.Name = "Technician";
            this.Technician.Size = new System.Drawing.Size(192, 20);
            this.Technician.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 107);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(48, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone #";
            // 
            // CustPhone
            // 
            this.CustPhone.BackColor = System.Drawing.SystemColors.Window;
            this.CustPhone.Location = new System.Drawing.Point(65, 104);
            this.CustPhone.Name = "CustPhone";
            this.CustPhone.Size = new System.Drawing.Size(192, 20);
            this.CustPhone.TabIndex = 2;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Location = new System.Drawing.Point(29, 81);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CustNameLabel.TabIndex = 1;
            this.CustNameLabel.Text = "Name";
            // 
            // CustName
            // 
            this.CustName.BackColor = System.Drawing.SystemColors.Menu;
            this.CustName.Enabled = false;
            this.CustName.Location = new System.Drawing.Point(65, 78);
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Size = new System.Drawing.Size(192, 20);
            this.CustName.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(10, 532);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(246, 532);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // JobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 570);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Edit Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox JobNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Comment;
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
        private System.Windows.Forms.TextBox CustPhone;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label lable1000;
        private System.Windows.Forms.CheckBox DoneCheckBox;
        private System.Windows.Forms.CheckBox PaidCheckBox;
        private System.Windows.Forms.CheckBox RushJobChecker;
        private System.Windows.Forms.Label CommentLabel;
    }
}