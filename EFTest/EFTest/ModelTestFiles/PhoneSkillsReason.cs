namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneSkillsReason")]
    public partial class PhoneSkillsReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhoneSkillsReason()
        {
            PhoneSkillsSequences = new HashSet<PhoneSkillsSequence>();
        }

        [Key]
        public int PHONE_SKILLS_REASON_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string REASON_TEXT { get; set; }

        [Required]
        public string REASON_DESCRIPTION { get; set; }

        public byte REASON_LEVEL { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneSkillsSequence> PhoneSkillsSequences { get; set; }
    }
}
