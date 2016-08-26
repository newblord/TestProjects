namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EOscarDetailDisputeCode")]
    public partial class EOscarDetailDisputeCode
    {
        [Key]
        public int EOSCAR_DETAIL_DISPUTE_CODE_KEY { get; set; }

        public int EOSCAR_BATCH_DETAIL_KEY { get; set; }

        public int EOSCAR_DISPUTE_CODE_KEY { get; set; }

        public virtual EOscarBatchDetail EOscarBatchDetail { get; set; }

        public virtual EOscarDisputeCode EOscarDisputeCode { get; set; }
    }
}
