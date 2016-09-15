namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfigInstanceTeller")]
    public partial class ProcessConfigInstanceTeller
    {
        [Key]
        public int PROCESS_CONFIG_INSTANCE_TELLER_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstance { get; set; }
    }
}
