namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoldItem")]
    public partial class GoldItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldItem()
        {
            GoldTransDetails = new HashSet<GoldTransDetail>();
            GoldConfigs = new HashSet<GoldConfig>();
        }

        [Key]
        public short GOLD_ITEM_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEM_DESCRIPTION { get; set; }

        [Required]
        [StringLength(1)]
        public string ITEM_TYPE { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldTransDetail> GoldTransDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldConfig> GoldConfigs { get; set; }
    }
}
