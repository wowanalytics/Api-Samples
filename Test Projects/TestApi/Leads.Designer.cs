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
            this.txtLeads.Location = new System.Drawing.Point(12, 75);
            this.txtLeads.Multiline = true;
            this.txtLeads.Name = "txtLeads";
            this.txtLeads.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLeads.Size = new System.Drawing.Size(666, 404);
            this.txtLeads.TabIndex = 3;
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 489);
            this.Controls.Add(this.txtLeads);
            this.Controls.Add(this.btnGetLeads);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLeadTypes);
            this.Name = "Leads";
            this.Text = "Leads";
            this.Load += new System.EventHandler(this.Leads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLeadTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetLeads;
        private System.Windows.Forms.TextBox txtLeads;
    }
}