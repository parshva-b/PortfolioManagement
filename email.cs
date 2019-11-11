using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioManagement
{
    class Email
    {
        public static void sendmail(string email, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(config.email);
                mail.To.Add(email);
                mail.Subject = "Forgot Password";

                mail.IsBodyHtml = true;
                string htmlBody;

                htmlBody = @"<h2>Forgot Your Password?</h2><h3>That's okay, it happens! Here is your password :)</h3><h1>" + password + "</h1>";

                mail.Body = htmlBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(config.email, config.password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                Debug.WriteLine("Sent mail");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
