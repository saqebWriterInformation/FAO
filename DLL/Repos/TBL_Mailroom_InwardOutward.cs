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
    
    public partial class TBL_Mailroom_InwardOutward
    {
        public int ID { get; set; }
        public string Send_Mode { get; set; }
        public string PlantID { get; set; }
        public string DocketNo { get; set; }
        public Nullable<int> CourierID { get; set; }
        public Nullable<int> HandoverUserID { get; set; }
        public Nullable<System.DateTime> Sent_DateTime { get; set; }
        public Nullable<int> No_of_Invoices_Outward { get; set; }
        public Nullable<int> No_of_Pages_Outward { get; set; }
        public string Outward_Remark { get; set; }
        public Nullable<int> OutwardBy { get; set; }
        public Nullable<System.DateTime> OutwardOn { get; set; }
        public Nullable<System.DateTime> Recieved_DateTime { get; set; }
        public string IS_InvoiceType { get; set; }
        public Nullable<int> No_of_Invoices_Inward { get; set; }
        public Nullable<int> No_of_Pages_Inward { get; set; }
        public Nullable<int> No_of_NPInvoices_Inward { get; set; }
        public Nullable<int> No_of_NPPages_Inward { get; set; }
        public string Inward_Remark { get; set; }
        public string IS_INWARD { get; set; }
        public Nullable<int> InwardBy { get; set; }
        public Nullable<System.DateTime> InwardOn { get; set; }
    }
}