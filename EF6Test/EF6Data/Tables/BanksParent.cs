namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BanksParent")]
    public partial class BanksParent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BanksParent()
        {
            BANKS = new HashSet<BANK>();
        }

        [Key]
        public int BANKS_PARENT_KEY { get; set; }

        [Required]
        [StringLength(128)]
        public string BANKS_PARENT_NAME { get; set; }

        public int ACH_BANK_KEY { get; set; }

        public bool ALLOWS_MIDDAY_PROCESSING { get; set; }

        public int CREDIT_ACH_BANK_KEY { get; set; }

        public int DEBIT_ACH_BANK_KEY { get; set; }

        public virtual ACHBank ACHBank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK> BANKS { get; set; }
    }
}
