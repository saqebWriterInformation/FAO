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
    
    public partial class USP_GetVendorInvoiceData_Result
    {
        public int ID { get; set; }
        public Nullable<int> SBUID { get; set; }
        public Nullable<System.DateTime> InwardStartDt { get; set; }
        public Nullable<int> InwardSrNo { get; set; }
        public string IsPOTypeInvoice { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<int> EntityGSTNoID { get; set; }
        public string GSTTaxType { get; set; }
        public string Barcode { get; set; }
        public string InwardID { get; set; }
        public string PONo { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<decimal> InvoiceServiceAmt { get; set; }
        public string FileOrgName { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Remark { get; set; }
        public Nullable<int> TDSSectionID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public Nullable<int> UploadedBy { get; set; }
        public Nullable<int> IsReject { get; set; }
        public string RejectRemark { get; set; }
        public Nullable<System.DateTime> RejectedDate { get; set; }
        public Nullable<int> RejectedBy { get; set; }
        public string RejectCheckList { get; set; }
        public string InvoiceGSTNo { get; set; }
        public string IsLock { get; set; }
        public Nullable<int> Data_LockBy { get; set; }
        public string IsTiff { get; set; }
        public string InvoiceCurrency { get; set; }
        public string IsTrash { get; set; }
        public string TrashRemark { get; set; }
        public Nullable<System.DateTime> TrashDate { get; set; }
        public Nullable<int> TrashBy { get; set; }
        public string IsActive { get; set; }
        public string IsReinitiate { get; set; }
        public string Old_Inward_ID { get; set; }
        public string TDSRate { get; set; }
        public string TDSCode { get; set; }
        public string TDSAmount { get; set; }
        public string IRN_No { get; set; }
        public string HSN_Code { get; set; }
        public Nullable<int> ID1 { get; set; }
        public Nullable<int> InwardSrNo1 { get; set; }
        public string PONo1 { get; set; }
        public string InwardID1 { get; set; }
        public string InvoiceNo1 { get; set; }
        public Nullable<System.DateTime> InvoiceDate1 { get; set; }
        public Nullable<System.DateTime> InvoiceStartDt { get; set; }
        public Nullable<System.DateTime> InvoiceRecDate { get; set; }
        public Nullable<decimal> BranchID { get; set; }
        public Nullable<int> SBUID1 { get; set; }
        public Nullable<decimal> VendorID1 { get; set; }
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
        public string InvoiceGSTNo1 { get; set; }
        public string IsAPProcessStarted { get; set; }
        public string PlantName { get; set; }
        public string PurchaserGSTIN { get; set; }
        public string SupplierGSTIN { get; set; }
        public string IRNNumber { get; set; }
        public string InvoiceCurrency1 { get; set; }
        public Nullable<decimal> InvoiceGrossAmt { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Priority { get; set; }
        public string FileName1 { get; set; }
        public string FilePath1 { get; set; }
        public string IsQCDone { get; set; }
        public string IsLock1 { get; set; }
        public Nullable<int> Data_LockBy1 { get; set; }
        public string IsInvValidateLocked { get; set; }
        public Nullable<System.DateTime> InvValidateLockedOn { get; set; }
        public Nullable<int> InvValidateLockedBy { get; set; }
        public string IsTrash1 { get; set; }
        public Nullable<System.DateTime> TrashDoneDate { get; set; }
        public Nullable<int> TrashDoneBy { get; set; }
        public string IsActive1 { get; set; }
        public string IsReinitiate1 { get; set; }
        public string Old_Inward_ID1 { get; set; }
        public string Comments { get; set; }
        public Nullable<int> TDSSectionID1 { get; set; }
        public string TDSRate1 { get; set; }
        public string TDSCode1 { get; set; }
        public string TDSAmount1 { get; set; }
        public Nullable<int> PO_ID { get; set; }
        public string PO_NO { get; set; }
        public string DRAFT_NO { get; set; }
        public Nullable<System.DateTime> PO_DATE { get; set; }
        public Nullable<int> BU { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_DESC { get; set; }
        public Nullable<int> LOC_ID { get; set; }
        public string LOC_DESC { get; set; }
        public Nullable<int> VENDOR_ID { get; set; }
        public string VENDOR_NAME { get; set; }
        public Nullable<int> CATEGORY_ID { get; set; }
        public string CATEGORY_DESC { get; set; }
        public Nullable<int> CUR_ID { get; set; }
        public string CUR_DESC { get; set; }
        public string COMMENTS1 { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> ENTRY_ID { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public Nullable<int> MODIFY_ID { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
        public Nullable<int> DELETE_ID { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
        public Nullable<System.DateTime> EXP_DELIVERY_DATE { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public string ADDRESS_ID { get; set; }
        public Nullable<bool> CUR_OVERRIDE { get; set; }
        public Nullable<decimal> CUR_RATE { get; set; }
        public string CREATORNAME { get; set; }
        public Nullable<System.DateTime> VALID_FROM { get; set; }
        public Nullable<System.DateTime> VALID_TO { get; set; }
        public Nullable<int> DIVISION_ID { get; set; }
        public string DIVISION_DESC { get; set; }
        public Nullable<decimal> BASE_TOTAL_AMOUNT { get; set; }
        public Nullable<int> BUDGETED_ID { get; set; }
        public string BUDGETED_DESC { get; set; }
        public Nullable<int> ADDENDUM_PO_ID { get; set; }
        public Nullable<int> ADDENDUM_SR_NO { get; set; }
        public Nullable<int> AMENDMENT_PO_ID { get; set; }
        public Nullable<int> AMENDMENT_SR_NO { get; set; }
        public Nullable<int> IS_AMENDMENT { get; set; }
        public Nullable<int> DELEGATE_ID { get; set; }
        public string DELEGATE_NAME { get; set; }
        public Nullable<int> GRN_OR_SRN { get; set; }
        public string GRN_OR_SRN_DESC { get; set; }
        public string ATTENTION_TO { get; set; }
        public string ATTENTION_CONTACT_NO { get; set; }
        public Nullable<int> ITEM_PARENT_ID { get; set; }
        public string ITEM_PARENT_DESC { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public Nullable<int> DELIVERY_LOCATION_ID { get; set; }
        public string DELIVERY_LOCATION_DESC { get; set; }
        public Nullable<int> BILLING_LOCATION_ID { get; set; }
        public string BILLING_LOCATION_DESC { get; set; }
        public string DELIVERY_TERM_DESC { get; set; }
        public Nullable<int> DELIVERY_TERM_ID { get; set; }
        public Nullable<int> PAYMENT_TERM_ID { get; set; }
        public string PAYMENT_TERM_DESC { get; set; }
        public string FILE_CERF_REF_NO { get; set; }
        public string TERM_CONDITION { get; set; }
        public string AGREED_DELIVERY_PERIOD { get; set; }
        public string VENDOR_REF_NO { get; set; }
        public string DELIVERY_ATTENTION_NO { get; set; }
        public Nullable<decimal> TAX { get; set; }
        public Nullable<decimal> ADDITIONAL_CHARGES { get; set; }
        public Nullable<decimal> BASE_TAX { get; set; }
        public Nullable<decimal> BASE_ADDITIONAL_CHARGES { get; set; }
        public Nullable<decimal> PO_AMOUNT { get; set; }
        public Nullable<decimal> BASE_PO_AMOUNT { get; set; }
        public string DELIVERY_ATTENTION_TO { get; set; }
        public Nullable<int> DUE_DAYS { get; set; }
        public Nullable<int> PROCESS_ID { get; set; }
        public string FilePath2 { get; set; }
        public string File_Name { get; set; }
        public string Buyer_GST { get; set; }
        public string PO_Status { get; set; }
        public string InwardStatus { get; set; }
        public string POFilePath { get; set; }
        public string POFileName { get; set; }
        public string InvRejectedRemark { get; set; }
        public Nullable<int> InvRejectedDate { get; set; }
    }
}