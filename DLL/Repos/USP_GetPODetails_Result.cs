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
    
    public partial class USP_GetPODetails_Result
    {
        public int PO_ID { get; set; }
        public string PO_No { get; set; }
        public Nullable<System.DateTime> PO_DATE { get; set; }
        public string ITEM_DESC { get; set; }
        public string HSNCode { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal GST { get; set; }
        public Nullable<decimal> Tax_ON { get; set; }
        public Nullable<decimal> GrossAmt { get; set; }
        public string GRNSRN { get; set; }
        public Nullable<int> LineSeqNo { get; set; }
    }
}
