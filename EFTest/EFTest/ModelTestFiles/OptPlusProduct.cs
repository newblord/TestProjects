namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusProduct")]
    public partial class OptPlusProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusProduct()
        {
            OptPlusBinProducts = new HashSet<OptPlusBinProduct>();
            OptPlusCardDetails = new HashSet<OptPlusCardDetail>();
        }

        [Key]
        public int OPTPLUS_PRODUCT_KEY { get; set; }

        [Required]
        [StringLength(6)]
        public string PRODUCT_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string PRODUCT_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string PRODUCT_DESCRIPTION { get; set; }

        public bool IS_WEB_PRODUCT { get; set; }

        public bool IS_EMPLOYEE { get; set; }

        public bool IS_OVERDRAFT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_TERMINATED { get; set; }

        public bool IS_ACTIVE_FOR_CHANGE_PRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusBinProduct> OptPlusBinProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetails { get; set; }
    }
}
