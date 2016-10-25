namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositChk")]
    public partial class DepositChk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepositChk()
        {
            DepositBags = new HashSet<DepositBag>();
            DepositChkDetails = new HashSet<DepositChkDetail>();
        }

        [Key]
        public int DEPOSIT_CHK_KEY { get; set; }

        public short LOCATION { get; set; }

        public int? DC_GL_ACCT { get; set; }

        [Column(TypeName = "money")]
        public decimal DC_CHK_TOT { get; set; }

        public int DC_CHK_CNTR { get; set; }

        public bool DC_PRA_TYPE { get; set; }

        [Required]
        [StringLength(3)]
        public string DC_DEPOSIT_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DC_DEPOSIT_DATE { get; set; }

        public bool DC_BAG_TYPE { get; set; }

        [StringLength(40)]
        public string DC_COURIER_NAME { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositBag> DepositBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepositChkDetail> DepositChkDetails { get; set; }
    }
}
