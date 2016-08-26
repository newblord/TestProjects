namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UDDReport")]
    public partial class UDDReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UDDReport()
        {
            UDDReportDetails = new HashSet<UDDReportDetail>();
        }

        [Key]
        public int UDD_REPORT_KEY { get; set; }

        public int ACH_RECV_KEY { get; set; }

        public DateTime UDD_PROCESSING_DATE { get; set; }

        public int ADVICE_NUMBER { get; set; }

        [Required]
        [StringLength(30)]
        public string REPORT_TYPE { get; set; }

        public DateTime ENTERED_DATE { get; set; }

        [StringLength(200)]
        public string FILE_NAME { get; set; }

        public virtual ACH_Recv ACH_Recv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UDDReportDetail> UDDReportDetails { get; set; }
    }
}
