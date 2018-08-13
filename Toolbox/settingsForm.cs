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
using System.IO;
using System.Security.Cryptography;
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

        public static class Encrypt
        {
            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            private const string initVector = "pemgail9uzpgzl88";

            // This constant is used to determine the keysize of the encryption algorithm
            private const int keysize = 256;

            //Encrypt
            public static string EncryptString(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }

            //Decrypt
            public static string DecryptString(string cipherText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
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

            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string encryptionKey = attribute.Value;

            string UnencrypedPassword = Encrypt.DecryptString(Properties.Settings.Default.Password, encryptionKey);
 
            // set all the fields in the form here, from the settings loaded above
            SMTPServer.Text = Properties.Settings.Default.SMTPServer;
            Port.Value = Properties.Settings.Default.SMTPPort;
            FromAddress.Text = Properties.Settings.Default.FromAddress;
            checkBoxUseAuth.Checked = Properties.Settings.Default.UseAuth;
            checkBoxUseSSL.Checked = Properties.Settings.Default.UseSSL;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            SMTPPassword.Text = UnencrypedPassword;
            textBoxTestDestination.Text = Properties.Settings.Default.TestDestination;
        }

        private void SaveSettings()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string encryptionKey = attribute.Value;
            string EncryptedSMTPPassword = Encrypt.EncryptString(SMTPPassword.Text, encryptionKey);

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
            catch (SmtpFailedRecipientException error)
            {
                MessageBox.Show("Test send failed" + error);
            }
        }
    }
}
