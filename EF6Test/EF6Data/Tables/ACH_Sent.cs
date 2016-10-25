namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACH_Sent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACH_Sent()
        {
            ACH_History = new HashSet<ACH_History>();
            ACH_HistoryCashedCheck = new HashSet<ACH_HistoryCashedCheck>();
        }

        [Key]
        public int ACH_SENT_KEY { get; set; }

        public short? LOCATION { get; set; }

        [Required]
        [StringLength(50)]
        public string FILE_NAME_SENT { get; set; }

        [Required]
        [StringLength(50)]
        public string FILE_NAME_UPDATED { get; set; }

        public int ITEM_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal ITEM_TOTAL { get; set; }

        public DateTime DATE_SENT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EXPECTED_RESULTS { get; set; }

        public int? ACH_RECV_KEY { get; set; }

        public bool SCHEDULED_PAYMENTS { get; set; }

        public bool? IS_AD_ASTRA { get; set; }

        [Required]
        [StringLength(1)]
        public string FILE_TYPE { get; set; }

        public bool? IS_DAY_AFTER_DUE_SENT { get; set; }

        public int? ACH_SENT_PARENT_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_HistoryCashedCheck> ACH_HistoryCashedCheck { get; set; }

        public virtual ACH_Recv ACH_Recv { get; set; }

        public virtual Company Company { get; set; }

        public virtual ACHSentParent ACHSentParent { get; set; }
    }
}
