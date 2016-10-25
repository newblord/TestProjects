namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoldTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldTran()
        {
            GoldTransCustomers = new HashSet<GoldTransCustomer>();
            GoldTransDetails = new HashSet<GoldTransDetail>();
        }

        [Key]
        public int GOLD_TRANS_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int DRAWER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int TRANS_POS_KEY { get; set; }

        public byte TOTAL_STONES { get; set; }

        public byte TOTAL_DIAMONDS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL_GOLD_WEIGHT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_OFFER_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_ACCEPTED_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OFFER_GOLD_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OFFER_DIAMOND_AMT { get; set; }

        [Required]
        [StringLength(3)]
        public string MOD_OVERRIDE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE { get; set; }

        public int BAG_NUM { get; set; }

        public int LOCATION_TRANS_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime MATURITY_DATE { get; set; }

        public bool REVERSED { get; set; }

        public int REVERSED_TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_BASE_MOD_OFFER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_MID_MOD_OFFER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_HIGH_MOD_OFFER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_OVERRIDE_MOD_OFFER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_TELLER_OFFER { get; set; }

        public byte ACCEPTED_OFFER_LEVEL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_10K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_14K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_18K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_22K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_24K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_HANDLING_FEE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_10K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_14K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_18K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_22K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_24K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_10K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_14K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_18K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_22K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_24K { get; set; }

        public byte OFFER_LEVEL_CODE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PLATINUM_WEIGHT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PLATINUM_LOSS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PLATINUM_PRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_WEIGHT_09K { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_LOSS_09K { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_09K { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransCustomer> GoldTransCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransDetail> GoldTransDetails { get; set; }
    }
}
