using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductFeatureType
    {
        public LoanProductFeatureType()
        {
            LoanProductFeature = new HashSet<LoanProductFeature>();
        }

        public int LoanProductFeatureTypeKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<LoanProductFeature> LoanProductFeature { get; set; }
    }
}
