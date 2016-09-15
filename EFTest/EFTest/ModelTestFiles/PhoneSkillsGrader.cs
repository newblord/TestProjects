namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneSkillsGrader")]
    public partial class PhoneSkillsGrader
    {
        [Key]
        public int PHONE_SKILLS_GRADER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }
    }
}
