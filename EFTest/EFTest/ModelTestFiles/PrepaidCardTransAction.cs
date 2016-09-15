namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardTransAction")]
    public partial class PrepaidCardTransAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardTransAction()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTran>();
            WSOperations = new HashSet<WSOperation>();
        }

        [Key]
        public int PREPAID_CARD_TRANS_ACTION_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string ACTION_NAME { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ACTIVE_CHANGED { get; set; }

        [StringLength(3)]
        public string TELLER_ACTIVE_CHANGED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardTran> PrepaidCardTrans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSOperation> WSOperations { get; set; }
    }
}
