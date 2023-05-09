using BLL.Transactions.VendorPortal.InvoiceSubmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FinanceAndAccountsOprations.Controllers
{
    public class HomeController : Controller
    {
         InvoiceReportBLL obj = new InvoiceReportBLL();
        public async Task<ActionResult> Index()
        {
             var result = await obj.GetAlluser();
             return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}