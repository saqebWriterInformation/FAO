//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL.Repos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_VendorPOMapping
    {
        public int ID { get; set; }
        public Nullable<decimal> VendorID { get; set; }
        public string PONo { get; set; }
        public Nullable<int> SBUTypeId { get; set; }
        public string Functions { get; set; }
        public string InvBranchcode { get; set; }
        public Nullable<int> BranchLocID { get; set; }
        public string POWIMSStatus { get; set; }
        public string InvoiceCurrency { get; set; }
    }
}
