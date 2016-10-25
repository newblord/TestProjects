namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldConfig")]
    public partial class GoldConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldConfig()
        {
            GoldItems = new HashSet<GoldItem>();
        }

        [Key]
        public short GOLD_CONFIG_KEY { get; set; }

        public short LOCATION { get; set; }

        public bool ENABLE_GOLD { get; set; }

        public bool ENABLE_DIAMOND { get; set; }

        public bool ENABLE_RECEIPT_DETAILS { get; set; }

        public bool ENABLE_ADDITIONAL_FORMS { get; set; }

        public byte MATURITY_LENGTH_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_DIAMOND_SIZE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MAX_DIAMOND_SIZE { get; set; }

        public byte MAX_DIAMONDS_PER_TRANS { get; set; }

        public byte MAX_DIAMONDS_PER_ITEM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DIAMOND_OFFER_MAX { get; set; }

        public byte GOLD_TELLER_PCT { get; set; }

        public byte GOLD_MOD_BASE_PCT { get; set; }

        public byte GOLD_MOD_MID_PCT { get; set; }

        public byte GOLD_MOD_HIGH_PCT { get; set; }

        public byte GOLD_MOD_OVERRIDE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_10K_LOSS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_14K_LOSS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_18K_LOSS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_22K_LOSS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_24K_LOSS_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REQUIRE_AUTH_TRANS_AMT { get; set; }

        public bool REQUIRE_ITEM_SIZE { get; set; }

        public bool REQUIRE_GENDER { get; set; }

        public bool REQUIRE_HEIGHT { get; set; }

        public bool REQUIRE_WEIGHT { get; set; }

        public bool REQUIRE_RACE { get; set; }

        public bool REQUIRE_EYE_COLOR { get; set; }

        public bool REQUIRE_HAIR_COLOR { get; set; }

        public bool REQUIRE_MIN_AGE { get; set; }

        public byte REQUIRE_AGE_VALUE { get; set; }

        public bool REQUIRE_HOME_PHONE { get; set; }

        public bool REQUIRE_EMPLOYER_NAME { get; set; }

        public bool REQUIRE_PLATE_NUMBER { get; set; }

        public bool REQUIRE_PLATE_STATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        public bool ENABLE_SPANISH_DOCS { get; set; }

        public bool REQUIRE_MID_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PLATINUM_LOSS_PCT { get; set; }

        public bool ENABLE_QUICK_QUOTE { get; set; }

        [Required]
        [StringLength(10)]
        public string POLICE_STORE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GOLD_09K_LOSS_PCT { get; set; }

        public bool GOVT_ID_REQUIRED { get; set; }

        [Required]
        [StringLength(75)]
        public string COMPANY_NAME { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldItem> GoldItems { get; set; }
    }
}