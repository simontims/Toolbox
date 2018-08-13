using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Toolbox
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            // This statement is to upgrade (pull forward) our settings from
            // a previous version. UpgradeRequired defaults to True.
            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            // Application GUID is our encryption key
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string encryptionKey = attribute.Value;

            string UnencryptedPassword = "";

            try
            {
                UnencryptedPassword = Encrypt.DecryptString(Properties.Settings.Default.Password.ToString(), encryptionKey.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // set all the fields in the form here, from the settings loaded above
            SMTPServer.Text = Properties.Settings.Default.SMTPServer;
            Port.Value = Properties.Settings.Default.SMTPPort;
            FromAddress.Text = Properties.Settings.Default.FromAddress;
            checkBoxUseAuth.Checked = Properties.Settings.Default.UseAuth;
            checkBoxUseSSL.Checked = Properties.Settings.Default.UseSSL;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            SMTPPassword.Text = UnencryptedPassword;
            textBoxTestDestination.Text = Properties.Settings.Default.TestDestination;
        }

        private void SaveSettings()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string encryptionKey = attribute.Value;
            string EncryptedSMTPPassword = "";

            try
            {
                EncryptedSMTPPassword = Encrypt.EncryptString(SMTPPassword.Text, encryptionKey);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Properties.Settings.Default.SMTPServer = SMTPServer.Text;
            Properties.Settings.Default.SMTPPort = Convert.ToInt32(Port.Value);
            Properties.Settings.Default.FromAddress = FromAddress.Text;
            Properties.Settings.Default.UseAuth = checkBoxUseAuth.Checked;
            Properties.Settings.Default.UseSSL = checkBoxUseSSL.Checked;
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = EncryptedSMTPPassword;
            Properties.Settings.Default.TestDestination = textBoxTestDestination.Text;

            Properties.Settings.Default.Save();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.SaveSettings();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // Don't save settings when testing
            try
            {
                using (MailMessage emailMessage = new MailMessage())
                {
                    emailMessage.BodyEncoding = UTF8Encoding.UTF8;
                    emailMessage.From = new MailAddress(FromAddress.Text);
                    emailMessage.To.Add (new MailAddress(textBoxTestDestination.Text));            
                    emailMessage.Subject = "This is a test email";
                    emailMessage.Body = "This is a test email body";
                    emailMessage.Priority = MailPriority.Normal;
                    emailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    using (SmtpClient client = new SmtpClient(SMTPServer.Text, Convert.ToInt32(Port.Value)))
                    {
                        client.Port = Convert.ToInt32(Port.Value);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Host = SMTPServer.Text;
                        client.EnableSsl = checkBoxUseSSL.Checked;
                        client.Timeout = 10000;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential(textBoxUsername.Text, SMTPPassword.Text);
                        client.Send(emailMessage);
                    }
                }
                MessageBox.Show("Test message sent");
            }
            catch (SmtpFailedRecipientException ex)
            {
                MessageBox.Show("Test send failed" + ex.ToString());
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            SMTPPassword.UseSystemPasswordChar = false;;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            SMTPPassword.UseSystemPasswordChar = true;
        }
    }
}
