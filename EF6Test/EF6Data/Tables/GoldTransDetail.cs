namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldTransDetail")]
    public partial class GoldTransDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldTransDetail()
        {
            GoldTransStoneDetails = new HashSet<GoldTransStoneDetail>();
        }

        [Key]
        public int GOLD_TRANS_DETAIL_KEY { get; set; }

        public int GOLD_TRANS_KEY { get; set; }

        public short GOLD_ITEM_KEY { get; set; }

        public byte METAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MARKINGS { get; set; }

        [Required]
        [StringLength(40)]
        public string ITEM_SIZE { get; set; }

        public byte NUM_GEMSTONES { get; set; }

        [Required]
        [StringLength(100)]
        public string GEM_DESCRIPTION { get; set; }

        public byte NUM_DIAMONDS { get; set; }

        public bool REVERSED { get; set; }

        public int REVERSED_TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal REVERSED_WEIGHT { get; set; }

        public bool REQUIRE_ITEM_SIZE { get; set; }

        public virtual GoldItem GoldItem { get; set; }

        public virtual GoldTran GoldTran { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransStoneDetail> GoldTransStoneDetails { get; set; }
    }
}
