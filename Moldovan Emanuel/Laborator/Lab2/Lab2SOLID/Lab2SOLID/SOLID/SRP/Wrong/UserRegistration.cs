using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Examples.SRP
{
    public class UserRegistration
    {
        public void RegisterUserIntoApplication(string password, string userName, string email)
        {
            // validate email
            bool isValid = false;
            if (String.IsNullOrEmpty(email)) return;
            else
            {
                isValid = Regex.IsMatch(email,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }

            if (isValid)
            {
                // encrypt credentials
                var encPassword = "";
                var encUserName = "";
                using (Aes myAes = Aes.Create())
                {

                    // Encrypt the string to an array of bytes.
                     encPassword = EncryptString_Aes(password, myAes.Key, myAes.IV);
                     encUsername = EncryptString_Aes(userName, myAes.Key, myAes.IV);
                }


                // store credentials and discount
                using (SqlConnection sql = new SqlConnection("connection-string"))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "INSERT INTO ... ";
                    command.Parameters.Add(encPassword);
                    command.Parameters.Add(encUserName);
                    command.BeginExecuteNonQuery();
                }

                // send confirmation email
                string to = email;
                string from = "random@random.com";
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Your account has been activated";
                message.Body = "asdjasnjkldna asjkdbnasjk bna;lfk nal;g kan'flsgn a'lkgna";
                SmtpClient client = new SmtpClient("server");
                client.Send(message);
            }
            
        }
    }
}
