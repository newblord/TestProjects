namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallLoggingLog")]
    public partial class WebCallLoggingLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallLoggingLog()
        {
            WebCallLoggingCategoryLogs = new HashSet<WebCallLoggingCategoryLog>();
        }

        [Key]
        public int WEB_CALL_LOGGING_LOG_KEY { get; set; }

        public int? WEB_CALL_LOGGING_LOG_EVENT_KEY { get; set; }

        public int PRIORITY { get; set; }

        [Required]
        [StringLength(32)]
        public string SEVERITY { get; set; }

        [Required]
        [StringLength(256)]
        public string TITLE { get; set; }

        public DateTime TIME_STAMP { get; set; }

        [Required]
        [StringLength(32)]
        public string MACHINE_NAME { get; set; }

        [Required]
        [StringLength(512)]
        public string APP_DOMAIN_NAME { get; set; }

        [Required]
        [StringLength(256)]
        public string WEB_CALL_LOGGING_LOG_KEY_PROCESS_KEY { get; set; }

        [Required]
        [StringLength(512)]
        public string PROCESS_NAME { get; set; }

        [StringLength(512)]
        public string THREAD_NAME { get; set; }

        [StringLength(128)]
        public string WIN_32_THREAD_ID { get; set; }

        [StringLength(1500)]
        public string MESSAGE { get; set; }

        [Column(TypeName = "ntext")]
        public string FORMATTED_MESSAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallLoggingCategoryLog> WebCallLoggingCategoryLogs { get; set; }
    }
}
