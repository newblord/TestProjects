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
    
    public partial class AACbExportDataArchive
    {
        public int ID { get; set; }
        public int AccountType { get; set; }
        public string AccountStatus { get; set; }
        public string DateOfLoss { get; set; }
        public string InputDate { get; set; }
        public string Creditor { get; set; }
        public int CreditorClassification { get; set; }
        public int ECOA { get; set; }
        public string PortfolioType { get; set; }
        public decimal AmountPastDue { get; set; }
        public decimal AmountDue { get; set; }
        public Nullable<decimal> HighestCredit { get; set; }
        public string LastPaymentDate { get; set; }
        public string TermsDuration { get; set; }
        public string ComplianceConditionCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string GenerationCode { get; set; }
        public string Street1 { get; set; }
        public Nullable<int> Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string SSN { get; set; }
        public string DOB { get; set; }
        public string DateClosed { get; set; }
        public System.DateTime EXPORT_DATE { get; set; }
        public string CII { get; set; }
    }
}
