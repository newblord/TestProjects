namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSOperation")]
    public partial class WSOperation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSOperation()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTran>();
        }

        [Key]
        public int WS_OPERATION_KEY { get; set; }

        public int WS_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string OPERATION_NAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string OPERATION_DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? PREPAID_CARD_TRANS_ACTION_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardTran> PrepaidCardTrans { get; set; }

        public virtual PrepaidCardTransAction PrepaidCardTransAction { get; set; }

        public virtual WSConfig WSConfig { get; set; }
    }
}
