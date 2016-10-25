using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterPrinted
    {
        public FormLetterPrinted()
        {
            FormLetterResult = new HashSet<FormLetterResult>();
        }

        public int FormLetterPrintedKey { get; set; }
        public int FormLetterKey { get; set; }
        public int CustomerKey { get; set; }
        public int CustomerAddressKey { get; set; }
        public int FormLetterBatchKey { get; set; }
        public int? FormLetterOnDemandKey { get; set; }
        public int? LoanKey { get; set; }
        public int? PromiseToPayDetailKey { get; set; }
        public byte FormLetterResultFileType { get; set; }
        public DateTime? VendorDatePrinted { get; set; }
        public string VendorJobCode { get; set; }
        public byte? ProcessingStateKey { get; set; }
        public int? CashedCheckKey { get; set; }
        public int? OptplusCardDetailKey { get; set; }
        public int? Dwdocid { get; set; }
        public int? RisreptKey { get; set; }

        public virtual ICollection<FormLetterResult> FormLetterResult { get; set; }
        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual CustomerAddress CustomerAddressKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual FormLetterBatch FormLetterBatchKeyNavigation { get; set; }
        public virtual FormLetter FormLetterKeyNavigation { get; set; }
        public virtual FormLetterOnDemand FormLetterOnDemandKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual OptPlusCardDetail OptplusCardDetailKeyNavigation { get; set; }
        public virtual PromiseToPayDetail PromiseToPayDetailKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
