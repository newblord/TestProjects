//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Notes_NoteHistory
    {
        public System.DateTime NOTEDATE { get; set; }
        public string TELLER { get; set; }
        public string DESCR { get; set; }
        public string NOTETEXT { get; set; }
        public decimal DOLLARAMOUNT { get; set; }
        public string TELLERNAME { get; set; }
        public string CUSTOM1 { get; set; }
        public string CUSTOM2 { get; set; }
        public string CUSTOM3 { get; set; }
        public int RISREPT_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> CASHED_CHECK_KEY { get; set; }
        public int COLLECTION_ACTION_KEY { get; set; }
    }
}
