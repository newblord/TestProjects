namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACH_Recv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACH_Recv()
        {
            ACH_History = new HashSet<ACH_History>();
            ACH_HistoryCashedCheck = new HashSet<ACH_HistoryCashedCheck>();
            ACH_Sent = new HashSet<ACH_Sent>();
            UDDReports = new HashSet<UDDReport>();
        }

        [Key]
        public int ACH_RECV_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string FILE_NAME_RECV { get; set; }

        public DateTime DATE_RECV { get; set; }

        public int PAID_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal PAID_TOTAL { get; set; }

        public int UNPAID_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal UNPAID_TOTAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BTIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_History> ACH_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_HistoryCashedCheck> ACH_HistoryCashedCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACH_Sent> ACH_Sent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UDDReport> UDDReports { get; set; }
    }
}
