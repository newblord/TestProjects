using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterOnDemand
    {
        public FormLetterOnDemand()
        {
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
        }

        public int FormLetterOnDemandKey { get; set; }
        public int FormLetterKey { get; set; }
        public int? FormLetterBatchKey { get; set; }
        public int? LoanKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string PromptData1 { get; set; }
        public string PromptData2 { get; set; }
        public string PromptData3 { get; set; }
        public string PromptData4 { get; set; }
        public string PromptData5 { get; set; }
        public int? CashedCheckKey { get; set; }
        public int? OptplusCardDetailKey { get; set; }

        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual FormLetterBatch FormLetterBatchKeyNavigation { get; set; }
        public virtual FormLetter FormLetterKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual OptPlusCardDetail OptplusCardDetailKeyNavigation { get; set; }
    }
}
