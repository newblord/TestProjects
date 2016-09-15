namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHBankConfigException")]
    public partial class ACHBankConfigException
    {
        [Key]
        public int ACH_BANK_CONFIG_EXCEPTION_KEY { get; set; }

        public int ACH_BANK_CONFIG_KEY { get; set; }

        public short LOC { get; set; }

        [Required]
        [StringLength(512)]
        public string VALUE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual ACHBankConfig ACHBankConfig { get; set; }

        public virtual Company Company { get; set; }
    }
}
