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
    
    public partial class tbl_InvoiceGSTDetails
    {
        public int ID { get; set; }
        public string InwardID { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> SBUID { get; set; }
        public string GSTNo { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public Nullable<int> LineSeqNo { get; set; }
        public string HSNCode { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> GSTAmount { get; set; }
        public Nullable<decimal> GrossAmt { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> EntryBy { get; set; }
        public Nullable<decimal> RCM { get; set; }
        public Nullable<decimal> CGSTAmount { get; set; }
        public Nullable<decimal> SGSTAmount { get; set; }
        public Nullable<decimal> IGSTAmount { get; set; }
        public Nullable<decimal> CESSAmount { get; set; }
        public Nullable<decimal> GSTPercentage { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<decimal> AmountTotal { get; set; }
        public Nullable<decimal> TDSAmount { get; set; }
        public Nullable<decimal> ToleranceAmt { get; set; }
        public string ToleranceUnit { get; set; }
        public string CostCentreCode { get; set; }
        public string GLCode { get; set; }
        public string PlantName { get; set; }
    }
}
