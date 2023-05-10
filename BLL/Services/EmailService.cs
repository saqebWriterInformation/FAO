using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmailService
    {
        public bool SendMail(string toEmails, string subject, string emailBody, bool isBodyHtml = true)
        {
            bool mailStatus = true;

            try
            {
                var mailClient = GetConfiguredSMTPClient();

                //---------EMail Sending Coade -----------------  //
                MailMessage mailMessage = new MailMessage(ConfigurationSettings.AppSettings["FromMailID"].ToString(), toEmails);
                mailMessage.Subject = subject;
                //--------------Mail Body----------------------------//
                mailMessage.IsBodyHtml = isBodyHtml;
                mailMessage.Body = emailBody;

                mailClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                mailStatus = false;
            }
            return mailStatus;
        }

        private SmtpClient GetConfiguredSMTPClient()
        {
            var a = ConfigurationSettings.AppSettings["MailHost"];
            SmtpClient mailClient = new SmtpClient(ConfigurationSettings.AppSettings["MailHost"].ToString(),
                Convert.ToInt32(ConfigurationSettings.AppSettings["MailPort"]));

            System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential(ConfigurationSettings.AppSettings["MailUserID"].ToString(),
                ConfigurationSettings.AppSettings["MailPassword"].ToString());
            mailClient.Credentials = basicAuthenticationInfo;

            return mailClient;
        }
    }
}
