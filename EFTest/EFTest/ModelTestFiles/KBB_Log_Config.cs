namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KBB_Log_Config
    {
        [Key]
        [Column(Order = 0)]
        public int KBB_LOG_CONFIG_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short KBB_LOGGING_STATUS { get; set; }

        [StringLength(1000)]
        public string KBB_LOG_DESC { get; set; }
    }
}
