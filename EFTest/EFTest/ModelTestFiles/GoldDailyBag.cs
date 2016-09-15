namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldDailyBag")]
    public partial class GoldDailyBag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldDailyBag()
        {
            GoldDailyBagDetails = new HashSet<GoldDailyBagDetail>();
            GoldTransferDetails = new HashSet<GoldTransferDetail>();
        }

        [Key]
        public int GOLD_DAILY_BAG_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int GB_GL_ACCT { get; set; }

        public int GB_BAG_NUM { get; set; }

        public short GB_BAG_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GB_BAG_TOTAL { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public bool REVERSED { get; set; }

        public int? REVERSED_TRANS_DETAIL_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldDailyBagDetail> GoldDailyBagDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransferDetail> GoldTransferDetails { get; set; }
    }
}
