namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfigDetailHistory")]
    public partial class ProcessConfigDetailHistory
    {
        [Key]
        [Column(Order = 0)]
        public int PROCESS_CONFIG_DETAIL_HIST_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PROCESS_CONFIG_DETAIL_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string CONFIG_NAME { get; set; }

        [Required]
        public string CONFIG_OLD_VALUE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public string CONFIG_NEW_VALUE { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstance { get; set; }
    }
}
