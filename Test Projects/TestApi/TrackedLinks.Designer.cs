namespace ServerWithApiKey
{
    partial class TrackedLinks
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
            this.label1 = new System.Windows.Forms.Label();
            this.valueTake = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.dataTrackedLinks = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetTrackedLinks = new System.Windows.Forms.Button();
            this.btnMarkProcessed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrackedLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take";
            // 
            // valueTake
            // 
            this.valueTake.Location = new System.Drawing.Point(100, 13);
            this.valueTake.Name = "valueTake";
            this.valueTake.Size = new System.Drawing.Size(120, 20);
            this.valueTake.TabIndex = 1;
            this.valueTake.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process Id";
            // 
            // txtProcessId
            // 
            this.txtProcessId.Location = new System.Drawing.Point(100, 43);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.ReadOnly = true;
            this.txtProcessId.Size = new System.Drawing.Size(242, 20);
            this.txtProcessId.TabIndex = 3;
            // 
            // dataTrackedLinks
            // 
            this.dataTrackedLinks.AllowUserToAddRows = false;
            this.dataTrackedLinks.AllowUserToDeleteRows = false;
            this.dataTrackedLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrackedLinks.Location = new System.Drawing.Point(16, 84);
            this.dataTrackedLinks.Name = "dataTrackedLinks";
            this.dataTrackedLinks.ReadOnly = true;
            this.dataTrackedLinks.Size = new System.Drawing.Size(797, 182);
            this.dataTrackedLinks.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetTrackedLinks
            // 
            this.btnGetTrackedLinks.Location = new System.Drawing.Point(431, 46);
            this.btnGetTrackedLinks.Name = "btnGetTrackedLinks";
            this.btnGetTrackedLinks.Size = new System.Drawing.Size(75, 23);
            this.btnGetTrackedLinks.TabIndex = 6;
            this.btnGetTrackedLinks.Text = "Get Tracked Links";
            this.btnGetTrackedLinks.UseVisualStyleBackColor = true;
            this.btnGetTrackedLinks.Click += new System.EventHandler(this.btnGetTrackedLinks_Click);
            // 
            // btnMarkProcessed
            // 
            this.btnMarkProcessed.Location = new System.Drawing.Point(556, 45);
            this.btnMarkProcessed.Name = "btnMarkProcessed";
            this.btnMarkProcessed.Size = new System.Drawing.Size(75, 23);
            this.btnMarkProcessed.TabIndex = 7;
            this.btnMarkProcessed.Text = "Mark Processed";
            this.btnMarkProcessed.UseVisualStyleBackColor = true;
            this.btnMarkProcessed.Click += new System.EventHandler(this.btnMarkProcessed_Click);
            // 
            // TrackedLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 312);
            this.Controls.Add(this.btnMarkProcessed);
            this.Controls.Add(this.btnGetTrackedLinks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataTrackedLinks);
            this.Controls.Add(this.txtProcessId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueTake);
            this.Controls.Add(this.label1);
            this.Name = "TrackedLinks";
            this.Text = "TrackedLinks";
            ((System.ComponentModel.ISupportInitialize)(this.valueTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrackedLinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valueTake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.DataGridView dataTrackedLinks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetTrackedLinks;
        private System.Windows.Forms.Button btnMarkProcessed;
    }
}