namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultCountService")]
    public partial class VaultCountService
    {
        [Key]
        public int VAULT_COUNT_SERVICE_KEY { get; set; }

        public int VAULT_COUNT_KEY { get; set; }

        public int SERVICE_DETAIL_KEY { get; set; }

        public int SERVICE_CNT { get; set; }

        public int SERVICE_CALC { get; set; }

        public virtual ServiceDetail ServiceDetail { get; set; }

        public virtual VaultCount VaultCount { get; set; }
    }
}
