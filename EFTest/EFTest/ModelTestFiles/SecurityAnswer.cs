namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityAnswer")]
    public partial class SecurityAnswer
    {
        [Key]
        public int SECURITY_ANSWER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int SECURITY_QUESTION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(50)]
        public string ANSWER { get; set; }

        public virtual SecurityQuestion SecurityQuestion { get; set; }
    }
}
