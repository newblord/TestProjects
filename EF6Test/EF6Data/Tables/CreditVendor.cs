namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditVendor")]
    public partial class CreditVendor
    {
        [Key]
        public int CREDIT_VENDOR_KEY { get; set; }

        public DateTime LAST_DATAX_RUN_TIME { get; set; }

        public DateTime LAST_CLVERIFY_RUN_TIME { get; set; }

        public DateTime LAST_VERITEC_MI_RUN_TIME { get; set; }

        public DateTime LAST_VERITEC_OK_RUN_TIME { get; set; }

        public DateTime LAST_VERITEC_ND_RUN_TIME { get; set; }

        public bool DATAX_ACTIVE { get; set; }

        public bool CLVERIFY_ACTIVE { get; set; }

        public bool VERITEC_MI_ACTIVE { get; set; }

        public bool VERITEC_OK_ACTIVE { get; set; }

        public bool VERITEC_ND_ACTIVE { get; set; }

        public bool GENTRY_ACTIVE { get; set; }

        public DateTime LAST_GENTRY_RUN_TIME { get; set; }

        public DateTime LAST_VERITEC_WA_RUN_TIME { get; set; }

        public bool VERITEC_WA_ACTIVE { get; set; }

        public DateTime LAST_FT_DAILY_RUN_TIME { get; set; }

        public DateTime? LAST_VERITEC_WI_RUN_TIME { get; set; }

        public bool? VERITEC_WI_ACTIVE { get; set; }

        public DateTime? LAST_VERITEC_IL_RUN_TIME { get; set; }

        public bool? VERITEC_IL_ACTIVE { get; set; }

        public bool? TELETRACKUK_ACTIVE { get; set; }

        public DateTime? LAST_TELETRACKUK_RUN_TIME { get; set; }

        public DateTime? LAST_CLARITY_RUN_TIME { get; set; }

        public bool? CLARITY_ACTIVE { get; set; }

        public bool IS_DATAX_BM_REPORTING_ACTIVE { get; set; }
    }
}
