using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PhoneSkillsGrade
    {
        public PhoneSkillsGrade()
        {
            PhoneSkillsCall = new HashSet<PhoneSkillsCall>();
        }

        public int PhoneSkillsGradeKey { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCall { get; set; }
    }
}
