namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneSkillsCall")]
    public partial class PhoneSkillsCall
    {
        [Key]
        public int PHONE_SKILLS_CALL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public short DISTRICT_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string STORE_MANAGER { get; set; }

        [StringLength(3)]
        public string STORE_TELLER { get; set; }

        [StringLength(60)]
        public string UNKNOWN_TELLER { get; set; }

        public string COMMENTS { get; set; }

        public bool DELETED { get; set; }

        [StringLength(12)]
        public string DELETED_DATE { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        public int PHONE_SKILLS_GRADE_KEY { get; set; }

        public int PHONE_SKILLS_SEQUENCE_KEY { get; set; }

        public int REASON_KEY { get; set; }

        public int SUBREASON1_KEY { get; set; }

        public int SUBREASON2_KEY { get; set; }

        public byte CALL_MONTH { get; set; }

        public short CALL_YEAR { get; set; }

        public virtual Company Company { get; set; }

        public virtual PhoneSkillsGrade PhoneSkillsGrade { get; set; }

        public virtual PhoneSkillsSequence PhoneSkillsSequence { get; set; }
    }
}
