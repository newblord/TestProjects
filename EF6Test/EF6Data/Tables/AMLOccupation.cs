namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AMLOccupation")]
    public partial class AMLOccupation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AMLOccupation()
        {
            AMLAdditionalParties = new HashSet<AMLAdditionalParty>();
        }

        [Key]
        public int AML_OCCUPATION_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [StringLength(75)]
        public string OCCUPATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        public int OCCUPATION_REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLAdditionalParty> AMLAdditionalParties { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
