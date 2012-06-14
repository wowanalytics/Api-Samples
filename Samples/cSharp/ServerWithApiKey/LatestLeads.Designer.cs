namespace ServerWithApiKey
{
    partial class LatestLeads
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumToGet = new System.Windows.Forms.MaskedTextBox();
            this.btnGetLatestLeads = new System.Windows.Forms.Button();
            this.dgLeads = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(467, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(294, 20);
            this.txtId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minutes";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(65, 101);
            this.txtMinutes.Mask = "00";
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(60, 20);
            this.txtMinutes.TabIndex = 13;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "# to get";
            // 
            // txtNumToGet
            // 
            this.txtNumToGet.Location = new System.Drawing.Point(194, 101);
            this.txtNumToGet.Mask = "000";
            this.txtNumToGet.Name = "txtNumToGet";
            this.txtNumToGet.Size = new System.Drawing.Size(60, 20);
            this.txtNumToGet.TabIndex = 13;
            this.txtNumToGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetLatestLeads
            // 
            this.btnGetLatestLeads.Location = new System.Drawing.Point(276, 99);
            this.btnGetLatestLeads.Name = "btnGetLatestLeads";
            this.btnGetLatestLeads.Size = new System.Drawing.Size(114, 23);
            this.btnGetLatestLeads.TabIndex = 14;
            this.btnGetLatestLeads.Text = "Get Latest Leads";
            this.btnGetLatestLeads.UseVisualStyleBackColor = true;
            this.btnGetLatestLeads.Click += new System.EventHandler(this.btnGetLatestLeads_Click);
            // 
            // dgLeads
            // 
            this.dgLeads.AllowUserToAddRows = false;
            this.dgLeads.AllowUserToDeleteRows = false;
            this.dgLeads.AllowUserToOrderColumns = true;
            this.dgLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLeads.Location = new System.Drawing.Point(12, 148);
            this.dgLeads.Name = "dgLeads";
            this.dgLeads.ReadOnly = true;
            this.dgLeads.Size = new System.Drawing.Size(555, 267);
            this.dgLeads.TabIndex = 15;
            // 
            // LatestLeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 475);
            this.Controls.Add(this.dgLeads);
            this.Controls.Add(this.btnGetLatestLeads);
            this.Controls.Add(this.txtNumToGet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Name = "LatestLeads";
            this.Text = "LatestLeads";
            ((System.ComponentModel.ISupportInitialize)(this.dgLeads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumToGet;
        private System.Windows.Forms.Button btnGetLatestLeads;
        private System.Windows.Forms.DataGridView dgLeads;
    }
}