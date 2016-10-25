using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FcrmAmlTransCode
    {
        public FcrmAmlTransCode()
        {
            AmlthresholdRuleTransXref = new HashSet<AmlthresholdRuleTransXref>();
            FcrmAmlCheckTypeXref = new HashSet<FcrmAmlCheckTypeXref>();
            FcrmAmlServiceXref = new HashSet<FcrmAmlServiceXref>();
            FcrmAmlTransCodeXref = new HashSet<FcrmAmlTransCodeXref>();
        }

        public int FcrmAmlTransCodeKey { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool DuplicateCashRecord { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<AmlthresholdRuleTransXref> AmlthresholdRuleTransXref { get; set; }
        public virtual ICollection<FcrmAmlCheckTypeXref> FcrmAmlCheckTypeXref { get; set; }
        public virtual ICollection<FcrmAmlServiceXref> FcrmAmlServiceXref { get; set; }
        public virtual ICollection<FcrmAmlTransCodeXref> FcrmAmlTransCodeXref { get; set; }
    }
}
