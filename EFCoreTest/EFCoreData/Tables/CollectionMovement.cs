using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollectionMovement
    {
        public int CollectionMovementKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int RisreptKey { get; set; }
        public int AuditKey { get; set; }
        public DateTime? FollowupDate { get; set; }
        public int? CollectionAgencyKey { get; set; }
        public byte? AssignmentNumber { get; set; }
        public string CrTeller { get; set; }
        public int? ReasonForArrearsKey { get; set; }

        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
