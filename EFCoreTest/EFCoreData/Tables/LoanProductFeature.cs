using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductFeature
    {
        public int LoanProductFeatureKey { get; set; }
        public int LoanProductKey { get; set; }
        public int LoanProductFeatureTypeKey { get; set; }
        public string Description { get; set; }
        public int? DisplayColor { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual LoanProductFeatureType LoanProductFeatureTypeKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
