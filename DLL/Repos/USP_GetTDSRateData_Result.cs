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
    
    public partial class USP_GetTDSRateData_Result
    {
        public int ID { get; set; }
        public string HSN_SACCode { get; set; }
        public string SACCode { get; set; }
        public string Description { get; set; }
        public string SACType { get; set; }
        public Nullable<decimal> TDSRate { get; set; }
        public string IsActive { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> GSTPerRate { get; set; }
        public string TYPE { get; set; }
        public Nullable<decimal> ToleranceLimit { get; set; }
        public string ToleranceUnit { get; set; }
        public string GLCode { get; set; }
        public Nullable<int> ID1 { get; set; }
        public string HSNSACCode { get; set; }
        public string GLCode1 { get; set; }
        public string Description1 { get; set; }
        public string IsActive1 { get; set; }
        public string CostCenter { get; set; }
    }
}
