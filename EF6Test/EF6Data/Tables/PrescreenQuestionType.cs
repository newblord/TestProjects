namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrescreenQuestionType")]
    public partial class PrescreenQuestionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrescreenQuestionType()
        {
            PrescreenQuestions = new HashSet<PrescreenQuestion>();
        }

        [Key]
        public int PRESCREEN_QUESTION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescreenQuestion> PrescreenQuestions { get; set; }
    }
}
