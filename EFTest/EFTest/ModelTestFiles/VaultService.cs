namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultService")]
    public partial class VaultService
    {
        [Key]
        public int VAULT_SERVICE_KEY { get; set; }

        public short LOCATION { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int VAULT_QTY { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}
