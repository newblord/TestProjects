namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldTransCustomer")]
    public partial class GoldTransCustomer
    {
        [Key]
        public int GOLD_TRANS_CUSTOMER_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string GENDER { get; set; }

        public byte HEIGHT_FEET { get; set; }

        public byte HEIGHT_INCHES { get; set; }

        public short WEIGHT { get; set; }

        public byte RACE { get; set; }

        public byte EYE_COLOR { get; set; }

        public byte HAIR_COLOR { get; set; }

        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYER_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string PLATE_NUMBER { get; set; }

        [Required]
        [StringLength(2)]
        public string PLATE_STATE { get; set; }

        public int GOLD_TRANS_KEY { get; set; }

        public bool REQUIRE_MID_NAME { get; set; }

        [Required]
        [StringLength(15)]
        public string CUST_MID_NAME { get; set; }

        public bool REQUIRE_NOTHING { get; set; }

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

        public virtual Customer Customer { get; set; }

        public virtual GoldTran GoldTran { get; set; }
    }
}
