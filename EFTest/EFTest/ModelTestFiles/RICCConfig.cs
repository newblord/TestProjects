namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RICCConfig")]
    public partial class RICCConfig
    {
        [Key]
        public int RICC_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(300)]
        public string AUDIT_CATEGORIES { get; set; }

        [Required]
        [StringLength(1000)]
        public string LOCATIONS { get; set; }

        public short AGE_FROM { get; set; }

        public short AGE_TO { get; set; }

        public bool INCLUDE_NETSPEND { get; set; }

        public bool INCLUDE_DEBIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE { get; set; }

        public byte NUMBER_THREADS { get; set; }

        public bool PROCESS_SPAY { get; set; }

        public bool PROCESS_MPAY { get; set; }

        public bool PROCESS_OEND { get; set; }
    }
}
