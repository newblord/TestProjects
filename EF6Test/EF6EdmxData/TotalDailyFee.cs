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
    
    public partial class TotalDailyFee
    {
        public int TOTAL_DAILY_FEES_KEY { get; set; }
        public short LOCATION { get; set; }
        public decimal STORE_FEES_PAYDAY { get; set; }
        public decimal STORE_FEES_TITLE { get; set; }
        public decimal STORE_FEES_SIG { get; set; }
        public decimal STORE_FEES_CASH_CHK { get; set; }
        public decimal STORE_FEES_OTHER { get; set; }
        public decimal INTERNET_FEES { get; set; }
        public decimal STORE_FEES_TOTAL { get; set; }
        public short STORE_FEES_RANK { get; set; }
        public decimal ALL_FEES_TOTAL { get; set; }
        public short ALL_FEES_RANK { get; set; }
    }
}