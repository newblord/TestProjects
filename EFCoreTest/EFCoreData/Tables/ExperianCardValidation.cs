using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExperianCardValidation
    {
        public int ExperianCardValidationKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public string CallName { get; set; }
        public string SentData { get; set; }
        public string Token { get; set; }
        public bool? SuccessfullyVerified { get; set; }
        public string ResponseId { get; set; }
        public string PreAuthorised { get; set; }
        public bool? AvsMatched { get; set; }
        public bool? CvvMatched { get; set; }
        public bool? PostcodeMatched { get; set; }
        public int? CardConditionCode { get; set; }
        public int? CardConditionReason { get; set; }
        public string CardConditionSeverity { get; set; }
        public string CardType { get; set; }
        public string CardSubType { get; set; }
        public string CardSchemeName { get; set; }
        public string CardIssuerName { get; set; }
        public string AbaMatchResult { get; set; }
        public string RawResponseData { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
