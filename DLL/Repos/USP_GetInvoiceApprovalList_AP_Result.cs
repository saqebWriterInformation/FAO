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
    
    public partial class USP_GetInvoiceApprovalList_AP_Result
    {
        public Nullable<long> SrNo { get; set; }
        public string InvoiceDate { get; set; }
        public int ID { get; set; }
        public Nullable<int> InwardSrNo { get; set; }
        public string PONo { get; set; }
        public string InwardID { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate1 { get; set; }
        public Nullable<System.DateTime> InvoiceStartDt { get; set; }
        public Nullable<System.DateTime> InvoiceRecDate { get; set; }
        public Nullable<decimal> BranchID { get; set; }
        public Nullable<int> SBUID { get; set; }
        public Nullable<decimal> VendorID { get; set; }
        public Nullable<decimal> InvoiceNetAmt { get; set; }
        public Nullable<decimal> ServiceAmt { get; set; }
        public Nullable<System.DateTime> FromMonth { get; set; }
        public Nullable<System.DateTime> ToMonth { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> OutwardDate { get; set; }
        public Nullable<int> OutwardUserID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<System.DateTime> BarcodeCreatedDt { get; set; }
        public Nullable<int> BarcodeCreatedBy { get; set; }
        public Nullable<bool> IsSendMailToSSC { get; set; }
        public Nullable<System.DateTime> SendMailToSSCDt { get; set; }
        public Nullable<int> SendMailToSSCBy { get; set; }
        public Nullable<bool> AckMailStatus { get; set; }
        public Nullable<System.DateTime> AckMailDate { get; set; }
        public Nullable<int> AckMailBy { get; set; }
        public string AckMailRemark { get; set; }
        public Nullable<bool> IsInvoiceError { get; set; }
        public Nullable<System.DateTime> CourierDate { get; set; }
        public Nullable<System.DateTime> CourierRecDate { get; set; }
        public Nullable<int> InwardUserID { get; set; }
        public string InvBranchcode { get; set; }
        public Nullable<int> SBUTypeId { get; set; }
        public Nullable<int> DeptID { get; set; }
        public string Functions { get; set; }
        public Nullable<bool> IsAccepted { get; set; }
        public string AutoApproveStatus_OCR { get; set; }
        public string AutoApproveRemark_OCR { get; set; }
        public string InvoiceGSTNo { get; set; }
        public string IsAPProcessStarted { get; set; }
        public string PlantName { get; set; }
        public string PurchaserGSTIN { get; set; }
        public string SupplierGSTIN { get; set; }
        public string IRNNumber { get; set; }
        public string InvoiceCurrency { get; set; }
        public Nullable<decimal> InvoiceGrossAmt { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Priority { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string IsQCDone { get; set; }
        public string IsLock { get; set; }
        public Nullable<int> Data_LockBy { get; set; }
        public string IsInvValidateLocked { get; set; }
        public Nullable<System.DateTime> InvValidateLockedOn { get; set; }
        public Nullable<int> InvValidateLockedBy { get; set; }
        public string IsTrash { get; set; }
        public Nullable<System.DateTime> TrashDoneDate { get; set; }
        public Nullable<int> TrashDoneBy { get; set; }
        public string IsActive { get; set; }
        public string IsReinitiate { get; set; }
        public string Old_Inward_ID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> TDSSectionID { get; set; }
        public string TDSRate { get; set; }
        public string TDSCode { get; set; }
        public string TDSAmount { get; set; }
        public string InvSatrtDate { get; set; }
        public string InvEndDate { get; set; }
        public string InvoiceType { get; set; }
        public string VendorGSTNO { get; set; }
        public string VendorStateCode { get; set; }
        public string VendorName { get; set; }
        public Nullable<decimal> InvoiceNetAmt1 { get; set; }
        public string AccountCode { get; set; }
        public string VendorEmail { get; set; }
        public string Comments1 { get; set; }
        public string VendorName1 { get; set; }
        public string AccountCode1 { get; set; }
        public string PAN { get; set; }
        public string Level { get; set; }
        public string View { get; set; }
    }
}