namespace ServerWithApiKey
{
    partial class Purl
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShortUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShortCode = new System.Windows.Forms.TextBox();
            this.chkFrameOptionsDeny = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCampaign = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(89, 17);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(507, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 131);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Short URL";
            // 
            // txtShortUrl
            // 
            this.txtShortUrl.Location = new System.Drawing.Point(134, 179);
            this.txtShortUrl.Name = "txtShortUrl";
            this.txtShortUrl.Size = new System.Drawing.Size(206, 20);
            this.txtShortUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Short Code";
            // 
            // txtShortCode
            // 
            this.txtShortCode.Location = new System.Drawing.Point(134, 209);
            this.txtShortCode.Name = "txtShortCode";
            this.txtShortCode.Size = new System.Drawing.Size(206, 20);
            this.txtShortCode.TabIndex = 1;
            // 
            // chkFrameOptionsDeny
            // 
            this.chkFrameOptionsDeny.AutoSize = true;
            this.chkFrameOptionsDeny.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFrameOptionsDeny.Location = new System.Drawing.Point(24, 235);
            this.chkFrameOptionsDeny.Name = "chkFrameOptionsDeny";
            this.chkFrameOptionsDeny.Size = new System.Drawing.Size(122, 17);
            this.chkFrameOptionsDeny.TabIndex = 3;
            this.chkFrameOptionsDeny.Text = "Frame Options Deny";
            this.chkFrameOptionsDeny.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(134, 258);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(410, 93);
            this.txtMessage.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(89, 43);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(507, 20);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // chkAlert
            // 
            this.chkAlert.AutoSize = true;
            this.chkAlert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlert.Location = new System.Drawing.Point(52, 95);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(47, 17);
            this.chkAlert.TabIndex = 3;
            this.chkAlert.Text = "Alert";
            this.chkAlert.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Campaign";
            // 
            // txtCampaign
            // 
            this.txtCampaign.Location = new System.Drawing.Point(89, 69);
            this.txtCampaign.Name = "txtCampaign";
            this.txtCampaign.Size = new System.Drawing.Size(507, 20);
            this.txtCampaign.TabIndex = 1;
            // 
            // Purl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 413);
            this.Controls.Add(this.chkAlert);
            this.Controls.Add(this.chkFrameOptionsDeny);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtShortCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShortUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCampaign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Purl";
            this.Text = "Purl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShortUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShortCode;
        private System.Windows.Forms.CheckBox chkFrameOptionsDeny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCampaign;
    }
}