namespace ServerWithApiKey
{
    partial class Leads
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
            this.cbLeadTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetLeads = new System.Windows.Forms.Button();
            this.txtLeads = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCampaign = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLeadTypes
            // 
            this.cbLeadTypes.FormattingEnabled = true;
            this.cbLeadTypes.Location = new System.Drawing.Point(86, 25);
            this.cbLeadTypes.Name = "cbLeadTypes";
            this.cbLeadTypes.Size = new System.Drawing.Size(240, 21);
            this.cbLeadTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lead Type";
            // 
            // btnGetLeads
            // 
            this.btnGetLeads.Location = new System.Drawing.Point(355, 23);
            this.btnGetLeads.Name = "btnGetLeads";
            this.btnGetLeads.Size = new System.Drawing.Size(75, 23);
            this.btnGetLeads.TabIndex = 2;
            this.btnGetLeads.Text = "Get Leads";
            this.btnGetLeads.UseVisualStyleBackColor = true;
            this.btnGetLeads.Click += new System.EventHandler(this.btnGetLeads_Click);
            // 
            // txtLeads
            // 
            this.txtLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeads.Location = new System.Drawing.Point(12, 265);
            this.txtLeads.Multiline = true;
            this.txtLeads.Name = "txtLeads";
            this.txtLeads.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLeads.Size = new System.Drawing.Size(697, 323);
            this.txtLeads.TabIndex = 3;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Page",
            "Keyword",
            "PPC"});
            this.cbSearch.Location = new System.Drawing.Point(86, 59);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(240, 21);
            this.cbSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Type";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(355, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Text";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(93, 19);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(240, 20);
            this.txtSource.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCampaign);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.txtTerm);
            this.groupBox1.Controls.Add(this.txtMedium);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UTM Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Medium";
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(93, 45);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(240, 20);
            this.txtMedium.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Term";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(93, 71);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(240, 20);
            this.txtTerm.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(433, 19);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(240, 20);
            this.txtContent.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Campaign";
            // 
            // txtCampaign
            // 
            this.txtCampaign.Location = new System.Drawing.Point(433, 45);
            this.txtCampaign.Name = "txtCampaign";
            this.txtCampaign.Size = new System.Drawing.Size(240, 20);
            this.txtCampaign.TabIndex = 6;
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLeads);
            this.Controls.Add(this.btnGetLeads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLeadTypes);
            this.Name = "Leads";
            this.Text = "Leads";
            this.Load += new System.EventHandler(this.Leads_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLeadTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLeads;
        private System.Windows.Forms.TextBox txtLeads;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCampaign;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}