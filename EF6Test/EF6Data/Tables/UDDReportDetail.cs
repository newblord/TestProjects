namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UDDReportDetail")]
    public partial class UDDReportDetail
    {
        [Key]
        public int UDD_REPORT_DETAIL_KEY { get; set; }

        public int UDD_REPORT_KEY { get; set; }

        public int? ACH_HISTORY_KEY { get; set; }

        public DateTime ORIGINAL_PROCESSING_DATE { get; set; }

        [Required]
        [StringLength(100)]
        public string RETURN_DESCRIPTION { get; set; }

        [Required]
        [StringLength(1)]
        public string RETURN_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string TRANS_CODE { get; set; }

        [Required]
        [StringLength(18)]
        public string REFERENCE { get; set; }

        [StringLength(18)]
        public string CORE_REFERENCE { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT { get; set; }

        public bool IS_PROCESSED { get; set; }

        public virtual ACH_History ACH_History { get; set; }

        public virtual UDDReport UDDReport { get; set; }
    }
}
