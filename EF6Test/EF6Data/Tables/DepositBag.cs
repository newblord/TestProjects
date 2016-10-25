namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositBag")]
    public partial class DepositBag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepositBag()
        {
            DepositBagDetails = new HashSet<DepositBagDetail>();
        }

        [Key]
        public int DEPOSIT_BAG_KEY { get; set; }

        public int? DEPOSIT_CHK_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(15)]
        public string DB_BAG_NUM { get; set; }

        [Required]
        [StringLength(3)]
        public string DB_ENTERED_BY { get; set; }

        public DateTime DB_DATE_ENTERED { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public bool DB_REVERSED { get; set; }

        public bool DB_MIDDAY_DEPOSIT { get; set; }

        public int? DB_REVERSE_TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal CASHED_CHK_TOTAL_AMT { get; set; }

        public int CASHED_CHK_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal PAYDAY_CHK_TOTAL_AMT { get; set; }

        public int PAYDAY_CHK_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal USD_CASHED_CHK_TOTAL_AMT { get; set; }

        public int USD_CASHED_CHK_COUNT { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CHK_TOTAL_AMT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? CHK_COUNT { get; set; }

        public bool IS_ELECTRONIC_BAG { get; set; }

        public virtual Company Company { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual DepositChk DepositChk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBagDetail> DepositBagDetails { get; set; }
    }
}
