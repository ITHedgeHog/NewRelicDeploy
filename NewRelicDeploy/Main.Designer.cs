namespace NewRelicDeploy
{
    partial class frmDeployment
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtChangeLog = new System.Windows.Forms.TextBox();
            this.lblChangeLog = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.lblRev = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.BtnPing = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(22, 26);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(57, 13);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "App Name";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(85, 26);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(280, 20);
            this.txtAppName.TabIndex = 1;
            this.txtAppName.Text = "My App Test";
            // 
            // txtChangeLog
            // 
            this.txtChangeLog.Location = new System.Drawing.Point(85, 60);
            this.txtChangeLog.Multiline = true;
            this.txtChangeLog.Name = "txtChangeLog";
            this.txtChangeLog.Size = new System.Drawing.Size(280, 102);
            this.txtChangeLog.TabIndex = 3;
            this.txtChangeLog.Text = "Change 1\r\nChange 2\r\nChange 3\r\netc...";
            // 
            // lblChangeLog
            // 
            this.lblChangeLog.AutoSize = true;
            this.lblChangeLog.Location = new System.Drawing.Point(22, 63);
            this.lblChangeLog.Name = "lblChangeLog";
            this.lblChangeLog.Size = new System.Drawing.Size(65, 13);
            this.lblChangeLog.TabIndex = 2;
            this.lblChangeLog.Text = "Change Log";
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(85, 300);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(100, 20);
            this.txtAppId.TabIndex = 5;
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(22, 300);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(40, 13);
            this.lblAppId.TabIndex = 4;
            this.lblAppId.Text = "App ID";
            // 
            // txtRevision
            // 
            this.txtRevision.Location = new System.Drawing.Point(85, 277);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(100, 20);
            this.txtRevision.TabIndex = 7;
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Location = new System.Drawing.Point(22, 277);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(48, 13);
            this.lblRev.TabIndex = 6;
            this.lblRev.Text = "Revision";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 326);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "Dan";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(22, 326);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(85, 168);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(280, 102);
            this.txtDesc.TabIndex = 13;
            this.txtDesc.Text = "End of sprint test refresh";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 168);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // BtnPing
            // 
            this.BtnPing.Location = new System.Drawing.Point(118, 410);
            this.BtnPing.Name = "BtnPing";
            this.BtnPing.Size = new System.Drawing.Size(75, 23);
            this.BtnPing.TabIndex = 14;
            this.BtnPing.Text = "Ping";
            this.BtnPing.UseVisualStyleBackColor = true;
            this.BtnPing.Click += new System.EventHandler(this.BtnPing_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(37, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(435, 26);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(285, 20);
            this.txtApiKey.TabIndex = 17;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(384, 26);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(45, 13);
            this.lblApiKey.TabIndex = 16;
            this.lblApiKey.Text = "API Key";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(391, 97);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 18;
            // 
            // frmDeployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 480);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnPing);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtRevision);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.lblAppId);
            this.Controls.Add(this.txtChangeLog);
            this.Controls.Add(this.lblChangeLog);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.lblAppName);
            this.Name = "frmDeployment";
            this.Text = "NewRelic Deployment Pinger";
            this.Load += new System.EventHandler(this.frmDeployment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtChangeLog;
        private System.Windows.Forms.Label lblChangeLog;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button BtnPing;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblOutput;
    }
}

