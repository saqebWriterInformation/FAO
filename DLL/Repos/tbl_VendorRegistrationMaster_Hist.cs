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
    
    public partial class tbl_VendorRegistrationMaster_Hist
    {
        public int HistID { get; set; }
        public Nullable<int> RegID { get; set; }
        public string CompanyName { get; set; }
        public string EmailID { get; set; }
        public string OrgTypeKey { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonDesig { get; set; }
        public Nullable<decimal> LandlineNumber { get; set; }
        public Nullable<decimal> MobileNo1 { get; set; }
        public Nullable<decimal> MobileNo2 { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Services { get; set; }
        public string Vend_PanNo { get; set; }
        public string GSTTypeKey { get; set; }
        public string GSTNumber { get; set; }
        public string CompanyBankAcc { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string OTP { get; set; }
        public string IsLock { get; set; }
        public Nullable<int> Data_LockBy { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> VendorCreatedDate { get; set; }
        public string ApprovedStatus { get; set; }
        public string RejectReasonKey { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public string IsUpdate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string UpdateApprovalStatus { get; set; }
        public Nullable<System.DateTime> UpdateApprovedDate { get; set; }
        public Nullable<int> UpdateApprovedBy { get; set; }
        public Nullable<System.DateTime> HistDate { get; set; }
        public Nullable<int> HistBy { get; set; }
        public string HistType { get; set; }
    }
}
