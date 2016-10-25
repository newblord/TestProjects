using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ddi
    {
        public Ddi()
        {
            Ddiachhistory = new HashSet<Ddiachhistory>();
            DdieditHistory = new HashSet<DdieditHistory>();
            DdisendDetail = new HashSet<DdisendDetail>();
            DdisendQueue = new HashSet<DdisendQueue>();
        }

        public int DdiKey { get; set; }
        public int LoanKey { get; set; }
        public string Reference { get; set; }
        public int StatusCode { get; set; }
        public DateTime StatusChangedDate { get; set; }
        public DateTime EnteredDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? ReSubmissionEmailSentDate { get; set; }

        public virtual ICollection<Ddiachhistory> Ddiachhistory { get; set; }
        public virtual ICollection<DdieditHistory> DdieditHistory { get; set; }
        public virtual ICollection<DdisendDetail> DdisendDetail { get; set; }
        public virtual ICollection<DdisendQueue> DdisendQueue { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Ddistatus StatusCodeNavigation { get; set; }
    }
}
