namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDNMain")]
    public partial class SDNMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SDNMain()
        {
            SDNAdds = new HashSet<SDNAdd>();
            SDNAlts = new HashSet<SDNAlt>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ENT_NUM { get; set; }

        [StringLength(350)]
        public string SDN_NAME { get; set; }

        [StringLength(16)]
        public string SDN_TYPE { get; set; }

        [StringLength(75)]
        public string PROGRAM { get; set; }

        [StringLength(300)]
        public string TITLE { get; set; }

        [StringLength(1500)]
        public string REMARKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SDNAdd> SDNAdds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SDNAlt> SDNAlts { get; set; }
    }
}
