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
    
    public partial class SP_GetNCRItemDetails_Result
    {
        public string PONo { get; set; }
        public string GRNNo { get; set; }
        public Nullable<int> LineSeqNo { get; set; }
        public string ItemCode { get; set; }
        public Nullable<decimal> ItemRate { get; set; }
        public Nullable<decimal> ItemAmount { get; set; }
        public string GRNStatus { get; set; }
        public Nullable<System.DateTime> GRNStatusDate { get; set; }
        public Nullable<int> GRNStatusBy { get; set; }
        public string StatusRemark { get; set; }
    }
}