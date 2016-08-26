namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSResponse")]
    public partial class WSResponse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSResponse()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTran>();
        }

        [Key]
        public int WS_RESPONSE_KEY { get; set; }

        public int WS_CONFIG_KEY { get; set; }

        [StringLength(14)]
        public string RESPONSE_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string RESPONSE_DESCRIPTION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardTran> PrepaidCardTrans { get; set; }

        public virtual WSConfig WSConfig { get; set; }
    }
}
