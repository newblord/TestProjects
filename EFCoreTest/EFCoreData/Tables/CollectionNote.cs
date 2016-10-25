using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollectionNote
    {
        public CollectionNote()
        {
            RepoCaseHistory = new HashSet<RepoCaseHistory>();
        }

        public int CollectionNoteKey { get; set; }
        public int RisreptKey { get; set; }
        public int CustomerKey { get; set; }
        public string Note { get; set; }
        public string RtfNote { get; set; }
        public bool IsFlash { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public int? NewCollectionNoteKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<RepoCaseHistory> RepoCaseHistory { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
