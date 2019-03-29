namespace Toolbox
{
    partial class settingsForm
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
            this.SMTPServer = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseSSL = new System.Windows.Forms.CheckBox();
            this.checkBoxUseAuth = new System.Windows.Forms.CheckBox();
            this.labelFromAddress = new System.Windows.Forms.Label();
            this.FromAddress = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelTestDest = new System.Windows.Forms.Label();
            this.textBoxTestDestination = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SMTPPassword = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabEmail = new System.Windows.Forms.TabPage();
            this.TabFTP = new System.Windows.Forms.TabPage();
            this.btnShowFTPPass = new System.Windows.Forms.Button();
            this.btnFTPTest = new System.Windows.Forms.Button();
            this.FTPLocalDir = new System.Windows.Forms.TextBox();
            this.FTPRemoteDir = new System.Windows.Forms.TextBox();
            this.FTPPassword = new System.Windows.Forms.TextBox();
            this.FTPUsername = new System.Windows.Forms.TextBox();
            this.checkBoxPASV = new System.Windows.Forms.CheckBox();
            this.lblLocalDir = new System.Windows.Forms.Label();
            this.lblremoteDir = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.FTPHostname = new System.Windows.Forms.TextBox();
            this.checkBoxSSLTLS = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFTPServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabEmail.SuspendLayout();
            this.TabFTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Server";
            // 
            // SMTPServer
            // 
            this.SMTPServer.Location = new System.Drawing.Point(106, 17);
            this.SMTPServer.Name = "SMTPServer";
            this.SMTPServer.Size = new System.Drawing.Size(269, 20);
            this.SMTPServer.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(387, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(419, 16);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(56, 20);
            this.Port.TabIndex = 4;
            this.Port.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // checkBoxUseSSL
            // 
            this.checkBoxUseSSL.AutoSize = true;
            this.checkBoxUseSSL.Location = new System.Drawing.Point(106, 76);
            this.checkBoxUseSSL.Name = "checkBoxUseSSL";
            this.checkBoxUseSSL.Size = new System.Drawing.Size(68, 17);
            this.checkBoxUseSSL.TabIndex = 7;
            this.checkBoxUseSSL.Text = "Use SSL";
            this.checkBoxUseSSL.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseAuth
            // 
            this.checkBoxUseAuth.AutoSize = true;
            this.checkBoxUseAuth.Location = new System.Drawing.Point(193, 76);
            this.checkBoxUseAuth.Name = "checkBoxUseAuth";
            this.checkBoxUseAuth.Size = new System.Drawing.Size(70, 17);
            this.checkBoxUseAuth.TabIndex = 8;
            this.checkBoxUseAuth.Text = "Use Auth";
            this.checkBoxUseAuth.UseVisualStyleBackColor = true;
            // 
            // labelFromAddress
            // 
            this.labelFromAddress.AutoSize = true;
            this.labelFromAddress.Location = new System.Drawing.Point(29, 53);
            this.labelFromAddress.Name = "labelFromAddress";
            this.labelFromAddress.Size = new System.Drawing.Size(71, 13);
            this.labelFromAddress.TabIndex = 9;
            this.labelFromAddress.Text = "From Address";
            // 
            // FromAddress
            // 
            this.FromAddress.Location = new System.Drawing.Point(106, 50);
            this.FromAddress.Name = "FromAddress";
            this.FromAddress.Size = new System.Drawing.Size(269, 20);
            this.FromAddress.TabIndex = 10;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(45, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(45, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(106, 107);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(269, 20);
            this.textBoxUsername.TabIndex = 13;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(8, 305);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(94, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(419, 172);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 17;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelTestDest
            // 
            this.labelTestDest.AutoSize = true;
            this.labelTestDest.Location = new System.Drawing.Point(14, 177);
            this.labelTestDest.Name = "labelTestDest";
            this.labelTestDest.Size = new System.Drawing.Size(84, 13);
            this.labelTestDest.TabIndex = 18;
            this.labelTestDest.Text = "Test Destination";
            // 
            // textBoxTestDestination
            // 
            this.textBoxTestDestination.Location = new System.Drawing.Point(106, 174);
            this.textBoxTestDestination.Name = "textBoxTestDestination";
            this.textBoxTestDestination.Size = new System.Drawing.Size(269, 20);
            this.textBoxTestDestination.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // SMTPPassword
            // 
            this.SMTPPassword.Location = new System.Drawing.Point(106, 138);
            this.SMTPPassword.Name = "SMTPPassword";
            this.SMTPPassword.Size = new System.Drawing.Size(269, 20);
            this.SMTPPassword.TabIndex = 23;
            this.SMTPPassword.UseSystemPasswordChar = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.TabEmail);
            this.tabControl1.Controls.Add(this.TabFTP);
            this.tabControl1.Location = new System.Drawing.Point(8, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 296);
            this.tabControl1.TabIndex = 24;
            // 
            // TabEmail
            // 
            this.TabEmail.Controls.Add(this.label1);
            this.TabEmail.Controls.Add(this.buttonTest);
            this.TabEmail.Controls.Add(this.button1);
            this.TabEmail.Controls.Add(this.SMTPPassword);
            this.TabEmail.Controls.Add(this.textBoxTestDestination);
            this.TabEmail.Controls.Add(this.SMTPServer);
            this.TabEmail.Controls.Add(this.labelTestDest);
            this.TabEmail.Controls.Add(this.Port);
            this.TabEmail.Controls.Add(this.labelFromAddress);
            this.TabEmail.Controls.Add(this.lblPort);
            this.TabEmail.Controls.Add(this.FromAddress);
            this.TabEmail.Controls.Add(this.checkBoxUseSSL);
            this.TabEmail.Controls.Add(this.checkBoxUseAuth);
            this.TabEmail.Controls.Add(this.labelUsername);
            this.TabEmail.Controls.Add(this.textBoxUsername);
            this.TabEmail.Controls.Add(this.labelPassword);
            this.TabEmail.Location = new System.Drawing.Point(4, 22);
            this.TabEmail.Name = "TabEmail";
            this.TabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.TabEmail.Size = new System.Drawing.Size(525, 270);
            this.TabEmail.TabIndex = 0;
            this.TabEmail.Text = "Email Send";
            this.TabEmail.UseVisualStyleBackColor = true;
            // 
            // TabFTP
            // 
            this.TabFTP.Controls.Add(this.btnShowFTPPass);
            this.TabFTP.Controls.Add(this.btnFTPTest);
            this.TabFTP.Controls.Add(this.FTPLocalDir);
            this.TabFTP.Controls.Add(this.FTPRemoteDir);
            this.TabFTP.Controls.Add(this.FTPPassword);
            this.TabFTP.Controls.Add(this.FTPUsername);
            this.TabFTP.Controls.Add(this.checkBoxPASV);
            this.TabFTP.Controls.Add(this.lblLocalDir);
            this.TabFTP.Controls.Add(this.lblremoteDir);
            this.TabFTP.Controls.Add(this.lblPassword);
            this.TabFTP.Controls.Add(this.FTPHostname);
            this.TabFTP.Controls.Add(this.checkBoxSSLTLS);
            this.TabFTP.Controls.Add(this.lblUserName);
            this.TabFTP.Controls.Add(this.lblFTPServer);
            this.TabFTP.Location = new System.Drawing.Point(4, 22);
            this.TabFTP.Name = "TabFTP";
            this.TabFTP.Padding = new System.Windows.Forms.Padding(3);
            this.TabFTP.Size = new System.Drawing.Size(525, 270);
            this.TabFTP.TabIndex = 1;
            this.TabFTP.Text = "FTP";
            this.TabFTP.UseVisualStyleBackColor = true;
            this.TabFTP.Click += new System.EventHandler(this.TabFTP_Click);
            // 
            // btnShowFTPPass
            // 
            this.btnShowFTPPass.Location = new System.Drawing.Point(380, 74);
            this.btnShowFTPPass.Name = "btnShowFTPPass";
            this.btnShowFTPPass.Size = new System.Drawing.Size(75, 23);
            this.btnShowFTPPass.TabIndex = 23;
            this.btnShowFTPPass.Text = "Show";
            this.btnShowFTPPass.UseVisualStyleBackColor = true;
            this.btnShowFTPPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowFTPPass_MouseDown);
            this.btnShowFTPPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowFTPPass_MouseUp);
            // 
            // btnFTPTest
            // 
            this.btnFTPTest.Location = new System.Drawing.Point(128, 216);
            this.btnFTPTest.Name = "btnFTPTest";
            this.btnFTPTest.Size = new System.Drawing.Size(75, 23);
            this.btnFTPTest.TabIndex = 12;
            this.btnFTPTest.Text = "Test";
            this.btnFTPTest.UseVisualStyleBackColor = true;
            this.btnFTPTest.Click += new System.EventHandler(this.btnFTPTest_Click);
            // 
            // FTPLocalDir
            // 
            this.FTPLocalDir.Location = new System.Drawing.Point(128, 136);
            this.FTPLocalDir.Name = "FTPLocalDir";
            this.FTPLocalDir.Size = new System.Drawing.Size(237, 20);
            this.FTPLocalDir.TabIndex = 11;
            // 
            // FTPRemoteDir
            // 
            this.FTPRemoteDir.Location = new System.Drawing.Point(128, 106);
            this.FTPRemoteDir.Name = "FTPRemoteDir";
            this.FTPRemoteDir.Size = new System.Drawing.Size(237, 20);
            this.FTPRemoteDir.TabIndex = 10;
            // 
            // FTPPassword
            // 
            this.FTPPassword.Location = new System.Drawing.Point(128, 76);
            this.FTPPassword.Name = "FTPPassword";
            this.FTPPassword.Size = new System.Drawing.Size(237, 20);
            this.FTPPassword.TabIndex = 9;
            this.FTPPassword.UseSystemPasswordChar = true;
            // 
            // FTPUsername
            // 
            this.FTPUsername.Location = new System.Drawing.Point(128, 46);
            this.FTPUsername.Name = "FTPUsername";
            this.FTPUsername.Size = new System.Drawing.Size(237, 20);
            this.FTPUsername.TabIndex = 8;
            // 
            // checkBoxPASV
            // 
            this.checkBoxPASV.AutoSize = true;
            this.checkBoxPASV.Location = new System.Drawing.Point(216, 177);
            this.checkBoxPASV.Name = "checkBoxPASV";
            this.checkBoxPASV.Size = new System.Drawing.Size(92, 17);
            this.checkBoxPASV.TabIndex = 7;
            this.checkBoxPASV.Text = "Passive mode";
            this.checkBoxPASV.UseVisualStyleBackColor = true;
            // 
            // lblLocalDir
            // 
            this.lblLocalDir.AutoSize = true;
            this.lblLocalDir.Location = new System.Drawing.Point(54, 139);
            this.lblLocalDir.Name = "lblLocalDir";
            this.lblLocalDir.Size = new System.Drawing.Size(49, 13);
            this.lblLocalDir.TabIndex = 6;
            this.lblLocalDir.Text = "Local Dir";
            this.lblLocalDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblremoteDir
            // 
            this.lblremoteDir.AutoSize = true;
            this.lblremoteDir.Location = new System.Drawing.Point(43, 109);
            this.lblremoteDir.Name = "lblremoteDir";
            this.lblremoteDir.Size = new System.Drawing.Size(60, 13);
            this.lblremoteDir.TabIndex = 5;
            this.lblremoteDir.Text = "Remote Dir";
            this.lblremoteDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FTPHostname
            // 
            this.FTPHostname.Location = new System.Drawing.Point(128, 16);
            this.FTPHostname.Name = "FTPHostname";
            this.FTPHostname.Size = new System.Drawing.Size(237, 20);
            this.FTPHostname.TabIndex = 3;
            // 
            // checkBoxSSLTLS
            // 
            this.checkBoxSSLTLS.AutoSize = true;
            this.checkBoxSSLTLS.Location = new System.Drawing.Point(128, 177);
            this.checkBoxSSLTLS.Name = "checkBoxSSLTLS";
            this.checkBoxSSLTLS.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSSLTLS.TabIndex = 2;
            this.checkBoxSSLTLS.Text = "SSL/TLS";
            this.checkBoxSSLTLS.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(48, 49);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFTPServer
            // 
            this.lblFTPServer.AutoSize = true;
            this.lblFTPServer.Location = new System.Drawing.Point(17, 19);
            this.lblFTPServer.Name = "lblFTPServer";
            this.lblFTPServer.Size = new System.Drawing.Size(86, 13);
            this.lblFTPServer.TabIndex = 0;
            this.lblFTPServer.Text = "Host name:[Port]";
            this.lblFTPServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 340);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "settingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabEmail.ResumeLayout(false);
            this.TabEmail.PerformLayout();
            this.TabFTP.ResumeLayout(false);
            this.TabFTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SMTPServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.CheckBox checkBoxUseSSL;
        private System.Windows.Forms.CheckBox checkBoxUseAuth;
        private System.Windows.Forms.Label labelFromAddress;
        private System.Windows.Forms.TextBox FromAddress;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTestDest;
        private System.Windows.Forms.TextBox textBoxTestDestination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SMTPPassword;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabFTP;
        private System.Windows.Forms.TabPage TabEmail;
        private System.Windows.Forms.Label lblLocalDir;
        private System.Windows.Forms.Label lblremoteDir;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox FTPHostname;
        private System.Windows.Forms.CheckBox checkBoxSSLTLS;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFTPServer;
        private System.Windows.Forms.TextBox FTPLocalDir;
        private System.Windows.Forms.TextBox FTPRemoteDir;
        private System.Windows.Forms.TextBox FTPPassword;
        private System.Windows.Forms.TextBox FTPUsername;
        private System.Windows.Forms.CheckBox checkBoxPASV;
        private System.Windows.Forms.Button btnFTPTest;
        private System.Windows.Forms.Button btnShowFTPPass;
    }
}