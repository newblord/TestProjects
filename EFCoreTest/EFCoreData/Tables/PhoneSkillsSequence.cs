using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PhoneSkillsSequence
    {
        public PhoneSkillsSequence()
        {
            PhoneSkillsCall = new HashSet<PhoneSkillsCall>();
        }

        public int PhoneSkillsSequenceKey { get; set; }
        public int ReasonKey { get; set; }
        public int Subreason1Key { get; set; }
        public int Subreason2Key { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCall { get; set; }
        public virtual PhoneSkillsReason ReasonKeyNavigation { get; set; }
    }
}
