namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDISend")]
    public partial class DDISend
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDISend()
        {
            DDISendDetails = new HashSet<DDISendDetail>();
        }

        [Key]
        public int DDI_SEND_KEY { get; set; }

        public DateTime SENT_DATE { get; set; }

        [StringLength(50)]
        public string FILE_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDISendDetail> DDISendDetails { get; set; }
    }
}
