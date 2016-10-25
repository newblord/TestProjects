namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardVendor")]
    public partial class CreditCardVendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CreditCardVendor()
        {
            CreditCardResultCodes = new HashSet<CreditCardResultCode>();
            CreditCardTrans = new HashSet<CreditCardTran>();
        }

        [Key]
        public byte CREDIT_CARD_VENDOR_KEY { get; set; }

        [Required]
        [StringLength(25)]
        public string CC_VENDOR_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardResultCode> CreditCardResultCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCardTran> CreditCardTrans { get; set; }
    }
}
