
namespace WhatsappBot
{
    partial class FormMain
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
            this.lblBar = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblContactGetInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBar
            // 
            this.lblBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(132)))));
            this.lblBar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBar.Location = new System.Drawing.Point(-2, 0);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(838, 30);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "   WHATSAPP BOT";
            this.lblBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseDown);
            this.lblBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseMove);
            this.lblBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBar_MouseUp);
            // 
            // lblQuit
            // 
            this.lblQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(132)))));
            this.lblQuit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuit.Location = new System.Drawing.Point(807, 0);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(29, 30);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Text = "X";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(1, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 443);
            this.panel.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(132)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(736, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblContactGetInfo
            // 
            this.lblContactGetInfo.AutoSize = true;
            this.lblContactGetInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblContactGetInfo.Location = new System.Drawing.Point(12, 37);
            this.lblContactGetInfo.Name = "lblContactGetInfo";
            this.lblContactGetInfo.Size = new System.Drawing.Size(0, 13);
            this.lblContactGetInfo.TabIndex = 4;
            this.lblContactGetInfo.Click += new System.EventHandler(this.lblContactGetInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 504);
            this.Controls.Add(this.lblContactGetInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.lblBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblContactGetInfo;
    }
}

