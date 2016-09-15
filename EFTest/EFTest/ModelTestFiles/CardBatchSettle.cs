namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardBatchSettle")]
    public partial class CardBatchSettle
    {
        [Key]
        public int CARD_BATCH_SETTLE_KEY { get; set; }

        public int? EOD_VAULT_COUNT_KEY { get; set; }

        [StringLength(1000)]
        public string REQUEST_DATA { get; set; }

        [StringLength(4000)]
        public string RESPONSE_DATA { get; set; }

        public bool ACCEPTED { get; set; }

        public DateTime? START_TIME { get; set; }

        public DateTime? END_TIME { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public short LOCATION { get; set; }

        public DateTime? END_BATCH_DATE_TIME { get; set; }

        public virtual VaultCount VaultCount { get; set; }
    }
}
