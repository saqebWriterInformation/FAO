using DLL;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Transactions.VendorPortal.InvoiceSubmission
{
    public class InvoiceReportBLL : GenericRepository<SYS_USERMASTER>
    {
      public async Task<List<SYS_USERMASTER>> GetAlluser()
        {
           return await DbContext.SYS_USERMASTER.ToListAsync();
        }
    }
}
