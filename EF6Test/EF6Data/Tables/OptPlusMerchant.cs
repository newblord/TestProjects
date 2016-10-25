namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusMerchant")]
    public partial class OptPlusMerchant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusMerchant()
        {
            OptPlusDirectDeposits = new HashSet<OptPlusDirectDeposit>();
            OptPlusRDFPostedTrans = new HashSet<OptPlusRDFPostedTran>();
        }

        [Key]
        public int OPTPLUS_MERCHANT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(30)]
        public string MERCHANT_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string MERCHANT_NAME { get; set; }

        [Required]
        [StringLength(4)]
        public string MERCHANT_CATEGORY { get; set; }

        [Required]
        [StringLength(5)]
        public string MERCHANT_COUNTRY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusDirectDeposit> OptPlusDirectDeposits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusRDFPostedTran> OptPlusRDFPostedTrans { get; set; }
    }
}
