using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MetroIibaseSegment
    {
        public int MetroiiBaseSegmentKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string CorrectionIndicator { get; set; }
        public string IdentificationNumber { get; set; }
        public string CycleIdentifier { get; set; }
        public int? ConsumerAccountNumber { get; set; }
        public string PortfolioType { get; set; }
        public string AccountType { get; set; }
        public DateTime DateOpened { get; set; }
        public int CreditLimit { get; set; }
        public int OriginalLoanAmount { get; set; }
        public short TermsDuration { get; set; }
        public string TermsFrequency { get; set; }
        public int SchedulePaymentAmount { get; set; }
        public int ActualPaymentAmount { get; set; }
        public string AccountStatus { get; set; }
        public string PaymentRating { get; set; }
        public string PaymentHistoryProfile { get; set; }
        public string SpecialComment { get; set; }
        public string ComplianceConditionCode { get; set; }
        public int CurrentBalance { get; set; }
        public int AmountPastDue { get; set; }
        public int OriginalChargeOffAmount { get; set; }
        public DateTime? DateFirstDelinquency { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime? DateLastPayment { get; set; }
        public string ConsumerTransactionType { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GenerationCode { get; set; }
        public string SocialInsuranceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }
        public string AssociationCode { get; set; }
        public string ConsumerInformationIndicator { get; set; }
        public string CountryCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string AddressIndicator { get; set; }
        public string ResidenceCode { get; set; }
        public int CustomerKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
