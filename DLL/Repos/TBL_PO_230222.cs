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
    
    public partial class TBL_PO_230222
    {
        public int PO_ID { get; set; }
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
        public string COMMENTS { get; set; }
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
        public string FilePath { get; set; }
        public string File_Name { get; set; }
        public string Buyer_GST { get; set; }
        public string PO_Status { get; set; }
    }
}
