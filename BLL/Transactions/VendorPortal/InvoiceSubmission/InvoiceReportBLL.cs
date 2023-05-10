using BLL.Services;
using DLL;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace BLL.Transactions.VendorPortal.InvoiceSubmission
{
    public class InvoiceReportBLL : GenericRepository<SYS_USERMASTER>
    {
      public async Task<List<SYS_USERMASTER>> GetAlluser()
        {
           SendEmail();
           return await DbContext.SYS_USERMASTER.ToListAsync();
        }

        public void SendEmail()
        {

            EmailService emailService = new EmailService();
            var reader = new StreamReader($@"{HostingEnvironment.MapPath("~")}\Templates\LoginCredential.htm");
            string readFile = reader.ReadToEnd();

            readFile = readFile.Replace("$$empname$$", "Saqeb Deshmukh");
            readFile = readFile.Replace("$$loginid$$", "V000001");
            readFile = readFile.Replace("$$pwd$$", "123456");

            emailService.SendMail("saqeb.deshmukh@writerinformation.com", "Login Credential", readFile);
        }
    }
}
