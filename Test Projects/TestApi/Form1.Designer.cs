namespace ServerWithApiKey
{
    partial class Form1
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
            this.btnGetClientDetails = new System.Windows.Forms.Button();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.btnGetClientDetials = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExpires = new System.Windows.Forms.TextBox();
            this.txtVisitsToday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVisitsMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTrackedLinks = new System.Windows.Forms.Button();
            this.btnLeads = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetClientDetails
            // 
            this.btnGetClientDetails.Location = new System.Drawing.Point(16, 56);
            this.btnGetClientDetails.Name = "btnGetClientDetails";
            this.btnGetClientDetails.Size = new System.Drawing.Size(102, 23);
            this.btnGetClientDetails.TabIndex = 2;
            this.btnGetClientDetails.Text = "Get Client List";
            this.btnGetClientDetails.UseVisualStyleBackColor = true;
            this.btnGetClientDetails.Click += new System.EventHandler(this.btnGetClientDetails_Click);
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(15, 38);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(314, 147);
            this.lstClients.TabIndex = 3;
            // 
            // btnGetClientDetials
            // 
            this.btnGetClientDetials.Location = new System.Drawing.Point(15, 240);
            this.btnGetClientDetials.Name = "btnGetClientDetials";
            this.btnGetClientDetials.Size = new System.Drawing.Size(139, 23);
            this.btnGetClientDetials.TabIndex = 4;
            this.btnGetClientDetials.Text = "Client Details";
            this.btnGetClientDetials.UseVisualStyleBackColor = true;
            this.btnGetClientDetials.Click += new System.EventHandler(this.btnGetClientDetials_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExpires);
            this.groupBox1.Controls.Add(this.txtVisitsToday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVisitsMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetClientDetials);
            this.groupBox1.Controls.Add(this.lstClients);
            this.groupBox1.Location = new System.Drawing.Point(16, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // txtExpires
            // 
            this.txtExpires.Location = new System.Drawing.Point(354, 200);
            this.txtExpires.Name = "txtExpires";
            this.txtExpires.Size = new System.Drawing.Size(294, 20);
            this.txtExpires.TabIndex = 7;
            // 
            // txtVisitsToday
            // 
            this.txtVisitsToday.Location = new System.Drawing.Point(354, 161);
            this.txtVisitsToday.Name = "txtVisitsToday";
            this.txtVisitsToday.Size = new System.Drawing.Size(294, 20);
            this.txtVisitsToday.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Expires";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Company Visits This Today";
            // 
            // txtVisitsMonth
            // 
            this.txtVisitsMonth.Location = new System.Drawing.Point(354, 117);
            this.txtVisitsMonth.Name = "txtVisitsMonth";
            this.txtVisitsMonth.Size = new System.Drawing.Size(294, 20);
            this.txtVisitsMonth.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Company Visits This Month";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(354, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(294, 20);
            this.txtId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(354, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnTrackedLinks
            // 
            this.btnTrackedLinks.Enabled = false;
            this.btnTrackedLinks.Location = new System.Drawing.Point(710, 115);
            this.btnTrackedLinks.Name = "btnTrackedLinks";
            this.btnTrackedLinks.Size = new System.Drawing.Size(125, 22);
            this.btnTrackedLinks.TabIndex = 8;
            this.btnTrackedLinks.Text = "Get Tracked Links";
            this.btnTrackedLinks.UseVisualStyleBackColor = true;
            this.btnTrackedLinks.Click += new System.EventHandler(this.btnTrackedLinks_Click);
            // 
            // btnLeads
            // 
            this.btnLeads.Enabled = false;
            this.btnLeads.Location = new System.Drawing.Point(710, 153);
            this.btnLeads.Name = "btnLeads";
            this.btnLeads.Size = new System.Drawing.Size(125, 23);
            this.btnLeads.TabIndex = 10;
            this.btnLeads.Text = "Lead Calls";
            this.btnLeads.UseVisualStyleBackColor = true;
            this.btnLeads.Click += new System.EventHandler(this.btnLeads_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 405);
            this.Controls.Add(this.btnLeads);
            this.Controls.Add(this.btnTrackedLinks);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetClientDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetClientDetails;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button btnGetClientDetials;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVisitsMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisitsToday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpires;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTrackedLinks;
        private System.Windows.Forms.Button btnLeads;
    }
}

