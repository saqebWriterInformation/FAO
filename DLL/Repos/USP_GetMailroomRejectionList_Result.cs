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
    
    public partial class USP_GetMailroomRejectionList_Result
    {
        public Nullable<long> SrNo { get; set; }
        public int RejID { get; set; }
        public string InwardID { get; set; }
        public Nullable<int> RejectID { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string IsLocked { get; set; }
        public Nullable<int> LockedBy { get; set; }
        public Nullable<System.DateTime> LockedDate { get; set; }
        public string ValidateStatus { get; set; }
        public Nullable<int> ValidateRejectID { get; set; }
        public string ValidateRemark { get; set; }
        public Nullable<System.DateTime> ValidateDate { get; set; }
        public Nullable<int> ValidateBy { get; set; }
        public string IsTrash { get; set; }
        public Nullable<System.DateTime> RejectionDate { get; set; }
        public string RejectName { get; set; }
        public string RejectionAt { get; set; }
        public string View { get; set; }
        public int ID { get; set; }
        public string InwardID1 { get; set; }
        public string BarcodeID { get; set; }
        public string PurchaserGSTIN { get; set; }
        public string SupplierGSTIN { get; set; }
        public string IsPOType { get; set; }
        public string PONo { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<decimal> InvoiceNetAmount { get; set; }
        public string IRNNumber { get; set; }
        public Nullable<decimal> SGSTAmount { get; set; }
        public Nullable<decimal> CGSTAmount { get; set; }
        public Nullable<decimal> IGSTAmount { get; set; }
        public Nullable<decimal> UTGSTAmount { get; set; }
        public Nullable<decimal> TCSAmount { get; set; }
        public Nullable<decimal> InvoiceGrossAmount { get; set; }
        public string GRNNumber { get; set; }
        public string SRNNumber { get; set; }
        public string OCRFileName { get; set; }
        public string OCRFilePath { get; set; }
        public Nullable<System.DateTime> OCRCreatedOn { get; set; }
        public string IsIndex { get; set; }
        public string IsRejectRevised { get; set; }
        public string IsLock { get; set; }
        public Nullable<int> Data_LockBy { get; set; }
        public string IsTiff { get; set; }
        public string IsActive { get; set; }
        public string IsReinitiate { get; set; }
        public string Old_Inward_ID { get; set; }
        public string HSN_Code { get; set; }
    }
}
