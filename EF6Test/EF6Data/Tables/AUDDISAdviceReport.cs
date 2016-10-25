namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDDISAdviceReport")]
    public partial class AUDDISAdviceReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUDDISAdviceReport()
        {
            AUDDISAdviceReportDetails = new HashSet<AUDDISAdviceReportDetail>();
        }

        [Key]
        public int AUDDIS_ADVICE_REPORT_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string REPORT_TYPE { get; set; }

        public DateTime REPORT_GENERATION_DATE { get; set; }

        [Required]
        [StringLength(20)]
        public string ADVICE_TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string FILE_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUDDISAdviceReportDetail> AUDDISAdviceReportDetails { get; set; }
    }
}
