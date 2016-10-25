namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneSkillsSequence")]
    public partial class PhoneSkillsSequence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhoneSkillsSequence()
        {
            PhoneSkillsCalls = new HashSet<PhoneSkillsCall>();
        }

        [Key]
        public int PHONE_SKILLS_SEQUENCE_KEY { get; set; }

        public int REASON_KEY { get; set; }

        public int SUBREASON1_KEY { get; set; }

        public int SUBREASON2_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCalls { get; set; }

        public virtual PhoneSkillsReason PhoneSkillsReason { get; set; }
    }
}
