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
using System.IO;
using System.Net;
using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Security;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using System.Text.RegularExpressions;

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
            string UnencryptedFTPPassword = "";
            string UnencryptedMailPassword = "";

            try
            {
                UnencryptedPassword = Encrypt.DecryptString(Properties.Settings.Default.Password.ToString(), encryptionKey.ToString());
                UnencryptedFTPPassword = Encrypt.DecryptString(Properties.Settings.Default.FTPPassword.ToString(), encryptionKey.ToString());
                UnencryptedMailPassword = Encrypt.DecryptString(Properties.Settings.Default.MailPassword.ToString(), encryptionKey.ToString());
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }

            // set all the fields in the form here, from the settings loaded above

            // System Tab
            if ((Properties.Settings.Default.TimerSeconds > numericTimerSeconds.Maximum) || (Properties.Settings.Default.TimerSeconds < numericTimerSeconds.Minimum))
            {
                numericTimerSeconds.Value = numericTimerSeconds.Minimum;
            }
            else
            {
                numericTimerSeconds.Value = Properties.Settings.Default.TimerSeconds;
            }

            // Email Send Tab
            SMTPServer.Text = Properties.Settings.Default.SMTPServer;
            Port.Value = Properties.Settings.Default.SMTPPort;
            FromAddress.Text = Properties.Settings.Default.FromAddress;
            checkBoxUseAuth.Checked = Properties.Settings.Default.UseAuth;
            checkBoxUseSSL.Checked = Properties.Settings.Default.UseSSL;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            SMTPPassword.Text = UnencryptedPassword;
            textBoxTestDestination.Text = Properties.Settings.Default.TestDestination;

            // Email Receive Tab
            MailServer.Text = Properties.Settings.Default.MailServer;
            MailPort.Value = Properties.Settings.Default.MailPort;
            textBoxMailUsername.Text = Properties.Settings.Default.MailUsername;
            MailPassword.Text = UnencryptedMailPassword;
            MailProtocol.Text = Properties.Settings.Default.MailProtocol;

            // FTP Tab
            FTPHostname.Text = Properties.Settings.Default.FTPHostName;
            FTPUsername.Text = Properties.Settings.Default.FTPUserName;
            FTPPassword.Text = UnencryptedFTPPassword;
            FTPRemoteDir.Text = Properties.Settings.Default.FTPRemoteDir;
            FTPLocalDir.Text = Properties.Settings.Default.FTPLocalDir;
            checkBoxSSLTLS.Checked = Properties.Settings.Default.FTPSSLTLS;
            checkBoxPASV.Checked = Properties.Settings.Default.FTPPASV;
        }

        private void SaveSettings()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string encryptionKey = attribute.Value;
            string EncryptedSMTPPassword = "";
            string EncryptedFTPPassword = "";
            string EncryptedMailPassword = "";

            try
            {
                EncryptedSMTPPassword = Encrypt.EncryptString(SMTPPassword.Text, encryptionKey);
                EncryptedFTPPassword = Encrypt.EncryptString(FTPPassword.Text, encryptionKey);
                EncryptedMailPassword = Encrypt.EncryptString(MailPassword.Text, encryptionKey);
            }
            catch ( Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }

            // System
            Properties.Settings.Default.TimerSeconds = Convert.ToInt32(numericTimerSeconds.Value);

            // Email Send
            Properties.Settings.Default.SMTPServer = SMTPServer.Text;
            Properties.Settings.Default.SMTPPort = Convert.ToInt32(Port.Value);
            Properties.Settings.Default.FromAddress = FromAddress.Text;
            Properties.Settings.Default.UseAuth = checkBoxUseAuth.Checked;
            Properties.Settings.Default.UseSSL = checkBoxUseSSL.Checked;
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = EncryptedSMTPPassword;
            Properties.Settings.Default.TestDestination = textBoxTestDestination.Text;

            // Email Receive
            Properties.Settings.Default.MailServer = MailServer.Text;
            Properties.Settings.Default.MailPort = Convert.ToInt32(MailPort.Value);
            Properties.Settings.Default.MailUsername = textBoxMailUsername.Text;
            Properties.Settings.Default.MailPassword = EncryptedMailPassword;
            Properties.Settings.Default.MailProtocol = MailProtocol.Text;

            // FTP
            Properties.Settings.Default.FTPHostName = FTPHostname.Text;
            Properties.Settings.Default.FTPUserName = FTPUsername.Text;
            Properties.Settings.Default.FTPPassword = EncryptedFTPPassword;
            Properties.Settings.Default.FTPRemoteDir = FTPRemoteDir.Text;
            Properties.Settings.Default.FTPLocalDir = FTPLocalDir.Text;
            Properties.Settings.Default.FTPSSLTLS = checkBoxSSLTLS.Checked;
            Properties.Settings.Default.FTPPASV = checkBoxPASV.Checked;

            Properties.Settings.Default.Save();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.SaveSettings();
            Program.LogToFile("Save settings");
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

        private void btnShowFTPPass_MouseDown(object sender, MouseEventArgs e)
        {
            FTPPassword.UseSystemPasswordChar = false;
        }

        private void btnShowFTPPass_MouseUp(object sender, MouseEventArgs e)
        {
            FTPPassword.UseSystemPasswordChar = true;
        }

        private void btnShowMailPass_MouseDown(object sender, MouseEventArgs e)
        {
            MailPassword.UseSystemPasswordChar = false;
        }

        private void btnShowMailPass_MouseUp(object sender, MouseEventArgs e)
        {
            MailPassword.UseSystemPasswordChar = true;
        }

        private void TabFTP_Click(object sender, EventArgs e)
        {

        }
        
        private void btnFTPTest_Click(object sender, EventArgs e)
        {
            // Don't save settings when testing
            string FTPUrl = null;
            if (!FTPHostname.Text.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase)) FTPUrl = "FTP://" + FTPHostname.Text;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPUrl);

            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            request.Credentials = new NetworkCredential(FTPUsername.Text, FTPPassword.Text);

            FtpWebResponse response = null;

            try
            {
                response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show($"Status {response.StatusDescription}");
                response.Close();
            }
            catch (WebException webex)
            {
                MessageBox.Show("Failed to connect: " + webex);
            }
            
        }

        private void buttonMailTest_Click(object sender, EventArgs e)
        {
            if (MailProtocol.Text == "POP")
            {
                MessageBox.Show("POP not yet supported");

                /*              
                try
                {
                    int messageCount = 0;
                    // using (var client = new Pop3Client(new ProtocolLogger("pop3.log")))
                    using (var client = new Pop3Client())
                    {
                        client.Connect(MailServer.Text, Convert.ToInt32(MailPort.Value), SecureSocketOptions.SslOnConnect);

                        client.Authenticate(textBoxMailUsername.Text, MailPassword.Text);

                        messageCount = client.Count;
                     
                        // Get all messages
                        //for (int i = 0; i < client.Count; i++)
                        //{
                        //    var message = client.GetMessage(i);

                            // Mark message for deletion
                        //    client.DeleteMessage(i);
                        //}
                        
                        client.Disconnect(true);
                    }
                    // Test email receive here
                    MessageBox.Show($"Connected OK: inbox contains {messageCount.ToString()} message(s)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Test receive failed" + ex.ToString());
                }
                */
            }
            else
            {
                // Don't save settings when testing
                try
                {
                    int messageCount = 0;
                    string returnMessage = "";
                    string ytTitle = "";
                    string ytUrl = "";
                    // using (var client = new Pop3Client(new ProtocolLogger("pop3.log")))
                    using (ImapClient client = new ImapClient())
                    {
                        client.Connect(MailServer.Text, Convert.ToInt32(MailPort.Value), SecureSocketOptions.SslOnConnect);

                        client.Authenticate(textBoxMailUsername.Text, MailPassword.Text);

                        client.Inbox.Open(FolderAccess.ReadOnly);
                        IList<UniqueId> uids = client.Inbox.Search(SearchQuery.NotSeen);
                     
                        foreach (UniqueId uid in uids)
                        {
                            MimeMessage message = client.Inbox.GetMessage(uid);
                            string subject = message.Subject;
                            // YouTube shares are 'Watch "Title" on YouTuve
                            // URL is in message body
                            if (subject.ToString().StartsWith("Watch \""))
                            {
                                // YouTube Video
                                Regex regex = new Regex("\"(.*?)\"");

                                var matches = regex.Matches(subject);

                                if (matches.Count > 0)
                                {
                                    ytTitle = matches[0].Groups[1].ToString();
                                }

                                ytUrl = message.TextBody;

                               returnMessage += $"MessageID {uid} is a YT share. Title: {ytTitle} URL: {ytUrl}\r\n\r\n";
                            }
                            else
                            {
                                returnMessage += $"MessageID {uid} (not a YT share) Subject: {subject.ToString()}\r\n\r\n";
                            }

                        }
                        

                        messageCount = uids.Count();

                        client.Disconnect(true);
                    }
                    // Test email receive here
                    MessageBox.Show($"Connected OK: inbox contains {messageCount.ToString()} message(s):\r\n\r\n" + returnMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Test receive failed" + ex.ToString());
                }
            }
        }

        

        /*
        // https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-list-directory-contents-with-ftp
        // https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-download-files-with-ftp
        // https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-upload-files-with-ftp

        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPHostname.Text);

        // Download
        request.Method = WebRequestMethods.Ftp.DownloadFile;

        // Could use ListDirectoryDetails to check connection
        // request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;


        request.Credentials = new NetworkCredential(FTPUsername.Text, FTPPassword.Text);

        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

        Stream responseStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(responseStream);

        Console.WriteLine(reader.ReadToEnd());

        Console.WriteLine($"Download Complete, status {response.StatusDescription}");

        reader.Close();
        response.Close();

        */

    }
}
