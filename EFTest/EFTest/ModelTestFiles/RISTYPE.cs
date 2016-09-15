namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RISTYPE")]
    public partial class RISTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RISTYPE()
        {
            RISREPTs = new HashSet<RISREPT>();
        }

        [StringLength(1)]
        public string TYPE { get; set; }

        [StringLength(25)]
        public string DESC { get; set; }

        [StringLength(10)]
        public string SHORT { get; set; }

        [Key]
        public int RIS_Type_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }
    }
}
