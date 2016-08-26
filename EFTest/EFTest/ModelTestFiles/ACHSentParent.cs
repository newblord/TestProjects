namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHSentParent")]
    public partial class ACHSentParent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHSentParent()
        {
            ACH_Sent = new HashSet<ACH_Sent>();
        }

        [Key]
        public int ACH_SENT_PARENT_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string ACH_FILE_NAME_SENT { get; set; }

        [Required]
        [StringLength(50)]
        public string ACH_FILE_NAME_ACK { get; set; }

        public int ACH_FILE_REC_CNT { get; set; }

        [Column(TypeName = "money")]
        public decimal ACH_FILE_TOTAL_AMT { get; set; }

        public DateTime ACH_SENT_DATE { get; set; }

        [Required]
        [StringLength(1)]
        public string FILE_TYPE { get; set; }

        public bool SCHEDULED_PAYMENTS { get; set; }

        public bool? IS_AD_ASTRA { get; set; }

        public bool? IS_DAY_AFTER_DUE_SENT { get; set; }

        public DateTime? EXPECTED_RESULTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_Sent> ACH_Sent { get; set; }
    }
}
