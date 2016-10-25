namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrescreenQuestion")]
    public partial class PrescreenQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrescreenQuestion()
        {
            PrescreenQuestionStates = new HashSet<PrescreenQuestionState>();
        }

        [Key]
        public int PRESCREEN_QUESTION_KEY { get; set; }

        public int PRESCREEN_QUESTION_TYPE_KEY { get; set; }

        [Required]
        [StringLength(1000)]
        public string MAIN_TEXT { get; set; }

        public bool VALID_RESPONSE { get; set; }

        public short SORT_ORDER { get; set; }

        public int? COLOR { get; set; }

        [Required]
        [StringLength(1000)]
        public string DETAIL_TEXT { get; set; }

        [Required]
        [StringLength(1000)]
        public string VALIDATION_MESSAGE { get; set; }

        public int? VALIDATION_MESSAGE_COLOR { get; set; }

        public bool IS_ACTIVE { get; set; }

        [StringLength(20)]
        public string QUESTION_NAME { get; set; }

        public virtual PrescreenQuestionType PrescreenQuestionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescreenQuestionState> PrescreenQuestionStates { get; set; }
    }
}
