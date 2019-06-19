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
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.numericTimerSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TabEmail = new System.Windows.Forms.TabPage();
            this.TabEmailReceive = new System.Windows.Forms.TabPage();
            this.MailProtocol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMailTest = new System.Windows.Forms.Button();
            this.buttonShowMailPassword = new System.Windows.Forms.Button();
            this.MailPassword = new System.Windows.Forms.TextBox();
            this.MailServer = new System.Windows.Forms.TextBox();
            this.MailPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMailUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.TabMTQQ = new System.Windows.Forms.TabPage();
            this.labelMQTTBroker = new System.Windows.Forms.Label();
            this.MqttBroker = new System.Windows.Forms.TextBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.MqttTopic = new System.Windows.Forms.TextBox();
            this.labelMqttPort = new System.Windows.Forms.Label();
            this.MqttPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerSeconds)).BeginInit();
            this.TabEmail.SuspendLayout();
            this.TabEmailReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailPort)).BeginInit();
            this.TabFTP.SuspendLayout();
            this.TabMTQQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MqttPort)).BeginInit();
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
            this.labelPassword.Location = new System.Drawing.Point(47, 141);
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
            this.labelTestDest.Location = new System.Drawing.Point(16, 177);
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
            this.tabControl1.Controls.Add(this.tabSystem);
            this.tabControl1.Controls.Add(this.TabEmail);
            this.tabControl1.Controls.Add(this.TabEmailReceive);
            this.tabControl1.Controls.Add(this.TabFTP);
            this.tabControl1.Controls.Add(this.TabMTQQ);
            this.tabControl1.Location = new System.Drawing.Point(8, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 296);
            this.tabControl1.TabIndex = 24;
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.numericTimerSeconds);
            this.tabSystem.Controls.Add(this.label3);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(525, 270);
            this.tabSystem.TabIndex = 3;
            this.tabSystem.Text = "System";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // numericTimerSeconds
            // 
            this.numericTimerSeconds.Location = new System.Drawing.Point(126, 12);
            this.numericTimerSeconds.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericTimerSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTimerSeconds.Name = "numericTimerSeconds";
            this.numericTimerSeconds.Size = new System.Drawing.Size(78, 20);
            this.numericTimerSeconds.TabIndex = 1;
            this.numericTimerSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Timer Seconds:";
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
            // TabEmailReceive
            // 
            this.TabEmailReceive.Controls.Add(this.MailProtocol);
            this.TabEmailReceive.Controls.Add(this.label2);
            this.TabEmailReceive.Controls.Add(this.buttonMailTest);
            this.TabEmailReceive.Controls.Add(this.buttonShowMailPassword);
            this.TabEmailReceive.Controls.Add(this.MailPassword);
            this.TabEmailReceive.Controls.Add(this.MailServer);
            this.TabEmailReceive.Controls.Add(this.MailPort);
            this.TabEmailReceive.Controls.Add(this.label4);
            this.TabEmailReceive.Controls.Add(this.label5);
            this.TabEmailReceive.Controls.Add(this.label6);
            this.TabEmailReceive.Controls.Add(this.textBoxMailUsername);
            this.TabEmailReceive.Controls.Add(this.label7);
            this.TabEmailReceive.Location = new System.Drawing.Point(4, 22);
            this.TabEmailReceive.Name = "TabEmailReceive";
            this.TabEmailReceive.Size = new System.Drawing.Size(525, 270);
            this.TabEmailReceive.TabIndex = 2;
            this.TabEmailReceive.Text = "Email Receive";
            this.TabEmailReceive.UseVisualStyleBackColor = true;
            // 
            // MailProtocol
            // 
            this.MailProtocol.FormattingEnabled = true;
            this.MailProtocol.Items.AddRange(new object[] {
            "POP",
            "IMAP"});
            this.MailProtocol.Location = new System.Drawing.Point(106, 49);
            this.MailProtocol.Name = "MailProtocol";
            this.MailProtocol.Size = new System.Drawing.Size(121, 21);
            this.MailProtocol.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mail Server";
            // 
            // buttonMailTest
            // 
            this.buttonMailTest.Location = new System.Drawing.Point(419, 151);
            this.buttonMailTest.Name = "buttonMailTest";
            this.buttonMailTest.Size = new System.Drawing.Size(75, 23);
            this.buttonMailTest.TabIndex = 35;
            this.buttonMailTest.Text = "Test";
            this.buttonMailTest.UseVisualStyleBackColor = true;
            this.buttonMailTest.Click += new System.EventHandler(this.buttonMailTest_Click);
            // 
            // buttonShowMailPassword
            // 
            this.buttonShowMailPassword.Location = new System.Drawing.Point(419, 115);
            this.buttonShowMailPassword.Name = "buttonShowMailPassword";
            this.buttonShowMailPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonShowMailPassword.TabIndex = 38;
            this.buttonShowMailPassword.Text = "Show";
            this.buttonShowMailPassword.UseVisualStyleBackColor = true;
            this.buttonShowMailPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowMailPass_MouseDown);
            this.buttonShowMailPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowMailPass_MouseUp);
            // 
            // MailPassword
            // 
            this.MailPassword.Location = new System.Drawing.Point(106, 117);
            this.MailPassword.Name = "MailPassword";
            this.MailPassword.Size = new System.Drawing.Size(269, 20);
            this.MailPassword.TabIndex = 39;
            this.MailPassword.UseSystemPasswordChar = true;
            // 
            // MailServer
            // 
            this.MailServer.Location = new System.Drawing.Point(106, 17);
            this.MailServer.Name = "MailServer";
            this.MailServer.Size = new System.Drawing.Size(269, 20);
            this.MailServer.TabIndex = 25;
            // 
            // MailPort
            // 
            this.MailPort.Location = new System.Drawing.Point(419, 16);
            this.MailPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MailPort.Name = "MailPort";
            this.MailPort.Size = new System.Drawing.Size(56, 20);
            this.MailPort.TabIndex = 27;
            this.MailPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Protocol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Username";
            // 
            // textBoxMailUsername
            // 
            this.textBoxMailUsername.Location = new System.Drawing.Point(106, 86);
            this.textBoxMailUsername.Name = "textBoxMailUsername";
            this.textBoxMailUsername.Size = new System.Drawing.Size(269, 20);
            this.textBoxMailUsername.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Password";
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
            // TabMTQQ
            // 
            this.TabMTQQ.Controls.Add(this.MqttPort);
            this.TabMTQQ.Controls.Add(this.labelMqttPort);
            this.TabMTQQ.Controls.Add(this.MqttTopic);
            this.TabMTQQ.Controls.Add(this.labelTopic);
            this.TabMTQQ.Controls.Add(this.MqttBroker);
            this.TabMTQQ.Controls.Add(this.labelMQTTBroker);
            this.TabMTQQ.Location = new System.Drawing.Point(4, 22);
            this.TabMTQQ.Name = "TabMTQQ";
            this.TabMTQQ.Size = new System.Drawing.Size(525, 270);
            this.TabMTQQ.TabIndex = 4;
            this.TabMTQQ.Text = "MQTT";
            this.TabMTQQ.UseVisualStyleBackColor = true;
            // 
            // labelMQTTBroker
            // 
            this.labelMQTTBroker.AutoSize = true;
            this.labelMQTTBroker.Location = new System.Drawing.Point(43, 19);
            this.labelMQTTBroker.Name = "labelMQTTBroker";
            this.labelMQTTBroker.Size = new System.Drawing.Size(72, 13);
            this.labelMQTTBroker.TabIndex = 0;
            this.labelMQTTBroker.Text = "MQTT Broker";
            this.labelMQTTBroker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MqttBroker
            // 
            this.MqttBroker.Location = new System.Drawing.Point(131, 16);
            this.MqttBroker.Name = "MqttBroker";
            this.MqttBroker.Size = new System.Drawing.Size(232, 20);
            this.MqttBroker.TabIndex = 1;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(79, 48);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(34, 13);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Topic";
            this.labelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MqttTopic
            // 
            this.MqttTopic.Location = new System.Drawing.Point(131, 45);
            this.MqttTopic.Name = "MqttTopic";
            this.MqttTopic.Size = new System.Drawing.Size(232, 20);
            this.MqttTopic.TabIndex = 3;
            // 
            // labelMqttPort
            // 
            this.labelMqttPort.AutoSize = true;
            this.labelMqttPort.Location = new System.Drawing.Point(372, 19);
            this.labelMqttPort.Name = "labelMqttPort";
            this.labelMqttPort.Size = new System.Drawing.Size(26, 13);
            this.labelMqttPort.TabIndex = 4;
            this.labelMqttPort.Text = "Port";
            // 
            // MqttPort
            // 
            this.MqttPort.Location = new System.Drawing.Point(404, 16);
            this.MqttPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MqttPort.Name = "MqttPort";
            this.MqttPort.Size = new System.Drawing.Size(85, 20);
            this.MqttPort.TabIndex = 5;
            this.MqttPort.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
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
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerSeconds)).EndInit();
            this.TabEmail.ResumeLayout(false);
            this.TabEmail.PerformLayout();
            this.TabEmailReceive.ResumeLayout(false);
            this.TabEmailReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailPort)).EndInit();
            this.TabFTP.ResumeLayout(false);
            this.TabFTP.PerformLayout();
            this.TabMTQQ.ResumeLayout(false);
            this.TabMTQQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MqttPort)).EndInit();
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
        private System.Windows.Forms.TabPage TabEmailReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMailTest;
        private System.Windows.Forms.Button buttonShowMailPassword;
        private System.Windows.Forms.TextBox MailPassword;
        private System.Windows.Forms.TextBox MailServer;
        private System.Windows.Forms.NumericUpDown MailPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMailUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MailProtocol;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.NumericUpDown numericTimerSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage TabMTQQ;
        private System.Windows.Forms.Label labelMQTTBroker;
        private System.Windows.Forms.TextBox MqttBroker;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox MqttTopic;
        private System.Windows.Forms.NumericUpDown MqttPort;
        private System.Windows.Forms.Label labelMqttPort;
    }
}