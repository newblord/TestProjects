namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormLetterOnDemand")]
    public partial class FormLetterOnDemand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormLetterOnDemand()
        {
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
        }

        [Key]
        public int FORM_LETTER_ON_DEMAND_KEY { get; set; }

        public int FORM_LETTER_KEY { get; set; }

        public int? FORM_LETTER_BATCH_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(50)]
        public string PROMPT_DATA_1 { get; set; }

        [Required]
        [StringLength(50)]
        public string PROMPT_DATA_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string PROMPT_DATA_3 { get; set; }

        [Required]
        [StringLength(50)]
        public string PROMPT_DATA_4 { get; set; }

        [Required]
        [StringLength(50)]
        public string PROMPT_DATA_5 { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual FormLetter FormLetter { get; set; }

        public virtual FormLetterBatch FormLetterBatch { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual OptPlusCardDetail OptPlusCardDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }
    }
}
