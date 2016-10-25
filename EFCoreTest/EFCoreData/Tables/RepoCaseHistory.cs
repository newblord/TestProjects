using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RepoCaseHistory
    {
        public int RepoCaseHistoryKey { get; set; }
        public int CollectionNoteKey { get; set; }
        public int TitleloanKey { get; set; }
        public int RisreptKey { get; set; }
        public string PreviousRepoCaseNum { get; set; }
        public string UpdatedRepoCaseNum { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual CollectionNote CollectionNoteKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
        public virtual TitleLoan TitleloanKeyNavigation { get; set; }
    }
}
