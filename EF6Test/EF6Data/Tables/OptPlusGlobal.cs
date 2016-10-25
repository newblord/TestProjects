namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusGlobal")]
    public partial class OptPlusGlobal
    {
        [Key]
        public int OPTPLUS_GLOBAL_KEY { get; set; }

        public short OD_NUM_LAST_DIRECT_DEPOSITS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OD_PERCENT_OF_DEPOSIT_AVG { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OD_MAX_AMT_RECV { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OD_MIN_DIRECT_DEPOSIT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OD_NON_DDP_MAX_AMT_TO_RECV { get; set; }

        public short MAX_DAYS_NEG_CARD_BALANCE { get; set; }

        public short NUM_DAYS_AFTER_DDP_FOR_RI { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_AMOUNT_PER_LOAD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_AMOUNT_LOST_CARD_BALANCE { get; set; }

        [Required]
        [StringLength(8)]
        public string REVERSAL_CUTOFF_TIME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_AMOUNT_PER_UNLOAD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_AMOUNT_PER_LOAD { get; set; }

        public bool IS_ENABLE_DIRECT_DEPOSIT_ODP { get; set; }

        public bool IS_ENABLE_NONDIRECT_DEPOSIT_ODP { get; set; }

        public short OD_NON_DDP_NUM_GOOD_LOANS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_BALANCE { get; set; }

        public byte MAX_LOADS_PER_DAY { get; set; }

        public byte MAX_UNLOADS_PER_DAY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_LOAD_AMOUNT_PER_DAY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_ATM_UNLOAD_AMOUNT_PER_DAY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_OTHER_UNLOAD_AMOUNT_PER_DAY { get; set; }

        public int PREPAID_CARD_BIN_KEY { get; set; }

        public virtual PrepaidCardBin PrepaidCardBin { get; set; }
    }
}
