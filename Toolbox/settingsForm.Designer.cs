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
            this.label2 = new System.Windows.Forms.Label();
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
            this.SMTPPassword = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Server";
            // 
            // SMTPServer
            // 
            this.SMTPServer.Location = new System.Drawing.Point(110, 22);
            this.SMTPServer.Name = "SMTPServer";
            this.SMTPServer.Size = new System.Drawing.Size(269, 20);
            this.SMTPServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(427, 22);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(91, 20);
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
            this.checkBoxUseSSL.Location = new System.Drawing.Point(110, 94);
            this.checkBoxUseSSL.Name = "checkBoxUseSSL";
            this.checkBoxUseSSL.Size = new System.Drawing.Size(68, 17);
            this.checkBoxUseSSL.TabIndex = 7;
            this.checkBoxUseSSL.Text = "Use SSL";
            this.checkBoxUseSSL.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseAuth
            // 
            this.checkBoxUseAuth.AutoSize = true;
            this.checkBoxUseAuth.Location = new System.Drawing.Point(200, 94);
            this.checkBoxUseAuth.Name = "checkBoxUseAuth";
            this.checkBoxUseAuth.Size = new System.Drawing.Size(70, 17);
            this.checkBoxUseAuth.TabIndex = 8;
            this.checkBoxUseAuth.Text = "Use Auth";
            this.checkBoxUseAuth.UseVisualStyleBackColor = true;
            // 
            // labelFromAddress
            // 
            this.labelFromAddress.AutoSize = true;
            this.labelFromAddress.Location = new System.Drawing.Point(21, 61);
            this.labelFromAddress.Name = "labelFromAddress";
            this.labelFromAddress.Size = new System.Drawing.Size(71, 13);
            this.labelFromAddress.TabIndex = 9;
            this.labelFromAddress.Text = "From Address";
            // 
            // FromAddress
            // 
            this.FromAddress.Location = new System.Drawing.Point(110, 58);
            this.FromAddress.Name = "FromAddress";
            this.FromAddress.Size = new System.Drawing.Size(269, 20);
            this.FromAddress.TabIndex = 10;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(37, 130);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(39, 163);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(110, 127);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(269, 20);
            this.textBoxUsername.TabIndex = 13;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(110, 248);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(427, 201);
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
            this.labelTestDest.Location = new System.Drawing.Point(8, 207);
            this.labelTestDest.Name = "labelTestDest";
            this.labelTestDest.Size = new System.Drawing.Size(84, 13);
            this.labelTestDest.TabIndex = 18;
            this.labelTestDest.Text = "Test Destination";
            // 
            // textBoxTestDestination
            // 
            this.textBoxTestDestination.Location = new System.Drawing.Point(111, 204);
            this.textBoxTestDestination.Name = "textBoxTestDestination";
            this.textBoxTestDestination.Size = new System.Drawing.Size(269, 20);
            this.textBoxTestDestination.TabIndex = 19;
            // 
            // SMTPPassword
            // 
            this.SMTPPassword.Location = new System.Drawing.Point(110, 163);
            this.SMTPPassword.Name = "SMTPPassword";
            this.SMTPPassword.Size = new System.Drawing.Size(270, 20);
            this.SMTPPassword.TabIndex = 20;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 296);
            this.Controls.Add(this.SMTPPassword);
            this.Controls.Add(this.textBoxTestDestination);
            this.Controls.Add(this.labelTestDest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.FromAddress);
            this.Controls.Add(this.labelFromAddress);
            this.Controls.Add(this.checkBoxUseAuth);
            this.Controls.Add(this.checkBoxUseSSL);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SMTPServer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "settingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SMTPServer;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.MaskedTextBox SMTPPassword;
    }
}