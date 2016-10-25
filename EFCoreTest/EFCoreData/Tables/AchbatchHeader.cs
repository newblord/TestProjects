using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchbatchHeader
    {
        public AchbatchHeader()
        {
            Achdetail = new HashSet<Achdetail>();
        }

        public int AchBatchHeaderKey { get; set; }
        public string RecordType { get; set; }
        public string ServiceClassCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDiscretionaryData { get; set; }
        public string CompanyId { get; set; }
        public string SecCode { get; set; }
        public string CompanyEntryDescription { get; set; }
        public string CompanyDescriptiveData { get; set; }
        public string EffectiveEntryDate { get; set; }
        public string JulianSettlementDate { get; set; }
        public string StatusCode { get; set; }
        public string OriginatingDfiRoutingNumber { get; set; }
        public string BatchNumber { get; set; }
        public bool ProcessedReturns { get; set; }

        public virtual ICollection<Achdetail> Achdetail { get; set; }
    }
}
