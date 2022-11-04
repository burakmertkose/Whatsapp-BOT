
namespace WhatsappBot.FormObjectModel
{
    partial class FormSendMessage
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
            this.clbxNumbers = new System.Windows.Forms.CheckedListBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMessageCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbxNumbers
            // 
            this.clbxNumbers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbxNumbers.FormattingEnabled = true;
            this.clbxNumbers.Location = new System.Drawing.Point(23, 47);
            this.clbxNumbers.Name = "clbxNumbers";
            this.clbxNumbers.Size = new System.Drawing.Size(182, 293);
            this.clbxNumbers.Sorted = true;
            this.clbxNumbers.TabIndex = 1;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(132)))));
            this.lblNumbers.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumbers.Location = new System.Drawing.Point(23, 21);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(182, 23);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.Text = " Numbers";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMessage.Location = new System.Drawing.Point(23, 373);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(797, 46);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxMessage.Location = new System.Drawing.Point(235, 93);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbxMessage.Size = new System.Drawing.Size(563, 118);
            this.rtbxMessage.TabIndex = 4;
            this.rtbxMessage.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxDelay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxMessageCount);
            this.groupBox1.Location = new System.Drawing.Point(235, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Repat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delay (second)";
            // 
            // tbxDelay
            // 
            this.tbxDelay.Location = new System.Drawing.Point(382, 28);
            this.tbxDelay.MaxLength = 4;
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.Size = new System.Drawing.Size(100, 20);
            this.tbxDelay.TabIndex = 2;
            this.tbxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Count";
            // 
            // tbxMessageCount
            // 
            this.tbxMessageCount.Location = new System.Drawing.Point(127, 28);
            this.tbxMessageCount.MaxLength = 5;
            this.tbxMessageCount.Name = "tbxMessageCount";
            this.tbxMessageCount.Size = new System.Drawing.Size(100, 20);
            this.tbxMessageCount.TabIndex = 0;
            this.tbxMessageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbxMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.clbxNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSendMessage";
            this.Text = "FormSendMessage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbxNumbers;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMessageCount;
    }
}