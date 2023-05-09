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
    
    public partial class TBL_COURIERINWARD_Hist_Old
    {
        public int ID { get; set; }
        public Nullable<decimal> InvoiceInwardID { get; set; }
        public string BarcodeID { get; set; }
        public string CourierName { get; set; }
        public string CourierAWBNum { get; set; }
        public string SenderName { get; set; }
        public Nullable<decimal> InvoiceTypeID { get; set; }
        public string SupportingDocList { get; set; }
        public string AddSuppDoc1 { get; set; }
        public string AddSuppDoc2 { get; set; }
        public Nullable<decimal> LocationID { get; set; }
        public Nullable<decimal> NoOfDocsRec { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> CourierRecDate { get; set; }
        public Nullable<System.DateTime> InvoiceInwDate { get; set; }
        public string InvoiceNum { get; set; }
        public string SBU { get; set; }
        public string BusinessSegment { get; set; }
        public Nullable<decimal> VendorId { get; set; }
        public string InvoiceBranchCode { get; set; }
        public string Month { get; set; }
        public Nullable<decimal> InwardUserId { get; set; }
        public Nullable<System.DateTime> InvoiceValidationOn { get; set; }
        public Nullable<decimal> InvoiceNetAmount { get; set; }
        public Nullable<decimal> InvoServiceTaxAmt { get; set; }
        public string InvoOtherTaxDesc { get; set; }
        public Nullable<decimal> InvoOtherTaxAmount { get; set; }
        public Nullable<decimal> InvoiceTotalAmount { get; set; }
        public string InvoiceIsValid { get; set; }
        public string AOP { get; set; }
        public string AOPType { get; set; }
        public string AOPRemark { get; set; }
        public string InwardID { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> ValidationBy { get; set; }
        public Nullable<System.DateTime> ValidatedOn { get; set; }
        public Nullable<decimal> InvApprovalSendBy { get; set; }
        public Nullable<System.DateTime> InvApprovalSendOn { get; set; }
        public Nullable<decimal> IsApproved { get; set; }
        public string ApprovalDone { get; set; }
        public string RejectStatus { get; set; }
        public string FunctionHead { get; set; }
        public string ApprovalFunHead { get; set; }
        public string ApprovalCFO { get; set; }
        public string ApprovalCEO { get; set; }
        public Nullable<System.DateTime> FrmMonth { get; set; }
        public Nullable<System.DateTime> ToMonth { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public string FilePath2 { get; set; }
        public Nullable<System.DateTime> ActCourierDate { get; set; }
        public string ApprBranchMgr { get; set; }
        public string ApprBranchAdm { get; set; }
        public string ApprBranchHR { get; set; }
        public string ApprBranchOpr { get; set; }
        public string ApprBranchFin { get; set; }
        public Nullable<bool> IsHold { get; set; }
        public Nullable<System.DateTime> HoldDate { get; set; }
        public Nullable<decimal> HoldBy { get; set; }
        public Nullable<bool> IsNCReject { get; set; }
        public Nullable<bool> IsRejected { get; set; }
        public Nullable<int> RejectedID { get; set; }
        public Nullable<System.DateTime> RejectedDate { get; set; }
        public Nullable<decimal> RejectedBy { get; set; }
        public Nullable<int> RejectionUserID { get; set; }
        public Nullable<bool> IsSendMail { get; set; }
        public Nullable<System.DateTime> SendMailDate { get; set; }
        public string MailType { get; set; }
        public string RejectType { get; set; }
        public string ApprFinanceHead { get; set; }
        public string Functions { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> GSTTotal { get; set; }
        public Nullable<decimal> GrossTotal { get; set; }
        public string VoucherType { get; set; }
        public Nullable<decimal> RCMTotal { get; set; }
        public string ApprBranchIT { get; set; }
        public string IsFinalApproved { get; set; }
        public string IsLocked { get; set; }
        public Nullable<System.DateTime> LockedOn { get; set; }
        public Nullable<int> LockedBy { get; set; }
        public string LockedAt { get; set; }
        public Nullable<bool> IS_NCRevised { get; set; }
        public Nullable<System.DateTime> NCRevisedDate { get; set; }
        public Nullable<int> NCRevisedBy { get; set; }
        public string NCRevisedRemark { get; set; }
        public string ActionType { get; set; }
        public Nullable<System.DateTime> ActionDate { get; set; }
        public Nullable<int> ActionBy { get; set; }
    }
}
