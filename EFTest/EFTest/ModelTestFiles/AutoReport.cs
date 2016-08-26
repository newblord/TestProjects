namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoReport")]
    public partial class AutoReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutoReport()
        {
            AutoReportEmails = new HashSet<AutoReportEmail>();
            AutoReportSchedules = new HashSet<AutoReportSchedule>();
            AutoReportTabs = new HashSet<AutoReportTab>();
        }

        [Key]
        public int AUTO_REPORT_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Required]
        [StringLength(100)]
        public string REPORT_NAME { get; set; }

        [Required]
        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(300)]
        public string OUTFILE { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string REPORT_SQL { get; set; }

        public bool RUN_MON { get; set; }

        public bool RUN_TUE { get; set; }

        public bool RUN_WED { get; set; }

        public bool RUN_THU { get; set; }

        public bool RUN_FRI { get; set; }

        public bool RUN_SAT { get; set; }

        public bool RUN_SUN { get; set; }

        public bool RUN_EOM { get; set; }

        public bool RUN_EOQ { get; set; }

        public bool RUN_EOY { get; set; }

        public byte RUN_DOM { get; set; }

        public bool OUTPUT_XLS { get; set; }

        public bool OUTPUT_PDF { get; set; }

        [Required]
        [StringLength(400)]
        public string SQL_FILE_LOCATION { get; set; }

        public bool ATTACH_FILE_TO_EMAIL { get; set; }

        public bool OUTPUT_CSV { get; set; }

        [Required]
        [StringLength(200)]
        public string EMAIL_SUBJECT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        public bool? DELETED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReportEmail> AutoReportEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReportSchedule> AutoReportSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReportTab> AutoReportTabs { get; set; }
    }
}
