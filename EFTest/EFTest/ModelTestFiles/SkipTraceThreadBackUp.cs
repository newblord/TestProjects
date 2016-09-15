namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkipTraceThreadBackUp")]
    public partial class SkipTraceThreadBackUp
    {
        [Key]
        [Column(Order = 0)]
        public int SKIP_TRACE_THREAD_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime DATE_ACTIVE { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IF_NO_ADDRESS { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IF_NO_CELL_PHONE { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IF_NO_HOME_PHONE { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IF_NO_WORK_PHONE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_LAST_CONTACT { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte PASS_COUNTER { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte STEP_NUMBER { get; set; }

        public int? SKIP_TRACE_STEP_KEY { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte VENDOR_NUMBER { get; set; }

        public int? SKIP_TRACE_VENDOR_KEY { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string TRACE_STATUS { get; set; }
    }
}
