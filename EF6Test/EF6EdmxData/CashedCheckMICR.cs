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
    
    public partial class CashedCheckMICR
    {
        public int CASHED_CHECK_MICR_KEY { get; set; }
        public int CASHED_CHECK_KEY { get; set; }
        public string MICRDATA { get; set; }
        public string AUX_ON_US { get; set; }
        public string TRANSIT_NUMBER { get; set; }
        public string EXTERNAL_PROCESSING_CODE { get; set; }
        public string CHECKSUM_DIGIT { get; set; }
        public string ON_US { get; set; }
        public string MICR_AMOUNT { get; set; }
        public string DEPOSIT_BANK_CONTROL_DATA { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
    
        public virtual CashedCheck CashedCheck { get; set; }
    }
}
