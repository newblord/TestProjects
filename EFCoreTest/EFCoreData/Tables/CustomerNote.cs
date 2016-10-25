using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerNote
    {
        public int CustomerNoteKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Note { get; set; }
        public int CustomerKey { get; set; }
        public string RtfNote { get; set; }
        public bool IsFlash { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public int? NewCustomerNoteKey { get; set; }
        public string EnteredBy { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
