using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PhoneSkillsReason
    {
        public PhoneSkillsReason()
        {
            PhoneSkillsSequence = new HashSet<PhoneSkillsSequence>();
        }

        public int PhoneSkillsReasonKey { get; set; }
        public string ReasonText { get; set; }
        public string ReasonDescription { get; set; }
        public byte ReasonLevel { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PhoneSkillsSequence> PhoneSkillsSequence { get; set; }
    }
}
