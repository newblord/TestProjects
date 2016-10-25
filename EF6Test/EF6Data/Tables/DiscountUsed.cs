namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountUsed")]
    public partial class DiscountUsed
    {
        [Key]
        public int DISCOUNT_USED_KEY { get; set; }

        public int DISCOUNT_MASTER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DISCOUNT_AMT { get; set; }

        [Required]
        [StringLength(5)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(4)]
        public string ROUTE_CODE { get; set; }

        public int? LOAN_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public virtual DiscountMaster DiscountMaster { get; set; }
    }
}
