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
    
    public partial class CustomerSurvey
    {
        public int CUSTOMER_SURVEY_KEY { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public short LOCATION { get; set; }
        public string TELLER { get; set; }
        public short TRANS_TYPE { get; set; }
        public bool NEW_CUSTOMER { get; set; }
        public byte NEW_PRA { get; set; }
        public byte NEW_TITLE { get; set; }
        public byte NEW_SIG { get; set; }
        public byte NEW_CHECK { get; set; }
        public bool NEW_TYPE { get; set; }
        public int RESPONSE_NUM { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string CALLED_NUM { get; set; }
        public string CALLED_FROM_NUM { get; set; }
        public string CALLED_FROM_CITY_STATE { get; set; }
        public Nullable<byte> QUESTION1 { get; set; }
        public Nullable<byte> QUESTION2 { get; set; }
        public Nullable<byte> QUESTION3 { get; set; }
        public Nullable<byte> QUESTION4 { get; set; }
        public Nullable<byte> QUESTION5 { get; set; }
        public Nullable<byte> QUESTION6 { get; set; }
        public Nullable<byte> QUESTION7 { get; set; }
        public Nullable<byte> QUESTION8 { get; set; }
        public Nullable<byte> QUESTION9 { get; set; }
        public Nullable<decimal> QUESTIONAVG { get; set; }
    }
}
