namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneSkillsGrade")]
    public partial class PhoneSkillsGrade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhoneSkillsGrade()
        {
            PhoneSkillsCalls = new HashSet<PhoneSkillsCall>();
        }

        [Key]
        public int PHONE_SKILLS_GRADE_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCalls { get; set; }
    }
}
