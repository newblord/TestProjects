using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PhoneSkillsCall
    {
        public int PhoneSkillsCallKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short DistrictKey { get; set; }
        public short Location { get; set; }
        public string StoreManager { get; set; }
        public string StoreTeller { get; set; }
        public string UnknownTeller { get; set; }
        public string Comments { get; set; }
        public bool Deleted { get; set; }
        public string DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public int PhoneSkillsGradeKey { get; set; }
        public int PhoneSkillsSequenceKey { get; set; }
        public int ReasonKey { get; set; }
        public int Subreason1Key { get; set; }
        public int Subreason2Key { get; set; }
        public byte CallMonth { get; set; }
        public short CallYear { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual PhoneSkillsGrade PhoneSkillsGradeKeyNavigation { get; set; }
        public virtual PhoneSkillsSequence PhoneSkillsSequenceKeyNavigation { get; set; }
    }
}
