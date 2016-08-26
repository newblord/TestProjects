namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMasterParsedCash")]
    public partial class VaultMasterParsedCash
    {
        [Key]
        public int VAULT_MASTER_PARSED_CASH_KEY { get; set; }

        public int VAULT_KEY { get; set; }

        public int DENOMINATION_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal AMOUNT { get; set; }

        public virtual Denomination Denomination { get; set; }

        public virtual VaultMaster VaultMaster { get; set; }
    }
}
