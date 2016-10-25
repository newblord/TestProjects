namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MSA")]
    public partial class MSA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSA()
        {
            US_Zipcodes = new HashSet<US_Zipcodes>();
        }

        [Key]
        [StringLength(4)]
        public string MSA_CODE { get; set; }

        [StringLength(4)]
        public string TYP { get; set; }

        [StringLength(60)]
        public string NAME { get; set; }

        [StringLength(2)]
        public string CMSA { get; set; }

        public double? POPULATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<US_Zipcodes> US_Zipcodes { get; set; }
    }
}
