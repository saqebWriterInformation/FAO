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
    
    public partial class USP_GetReportData_AP_Result
    {
        public Nullable<long> Invoice_ID { get; set; }
        public string Plant_Name { get; set; }
        public string Entity_Name { get; set; }
        public string Purchase_GSTIN { get; set; }
        public string Barcode_Number { get; set; }
        public string IRN_Number { get; set; }
        public string Invoice_Type { get; set; }
        public Nullable<System.DateTime> Invoice_Submission_Date { get; set; }
        public string Vendor_Code { get; set; }
        public string Supplier_GSTIN { get; set; }
        public string Vendor_Name { get; set; }
        public string Invoice_Date { get; set; }
        public string Invoice_Number { get; set; }
        public string PO_Number { get; set; }
        public string GRN_Number { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Invoice_Net_Amount { get; set; }
        public Nullable<decimal> CGST_Amount { get; set; }
        public Nullable<decimal> SGST_Amount { get; set; }
        public Nullable<decimal> IGST_Amount { get; set; }
        public Nullable<decimal> TCS_Amount { get; set; }
        public Nullable<decimal> TDS_Amount { get; set; }
        public Nullable<decimal> Gross_Amount { get; set; }
        public string Invoice_Queue_Status { get; set; }
        public string Portal { get; set; }
        public string Batch_ID { get; set; }
    }
}