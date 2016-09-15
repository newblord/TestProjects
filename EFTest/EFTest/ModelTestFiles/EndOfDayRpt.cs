namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EndOfDayRpt")]
    public partial class EndOfDayRpt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EndOfDayRpt()
        {
            EndOfDayRptDetails = new HashSet<EndOfDayRptDetail>();
        }

        [Key]
        public int EODR_KEY { get; set; }

        public int BALSHEET_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool RE_GEN { get; set; }

        public virtual BalSheet2 BalSheet2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EndOfDayRptDetail> EndOfDayRptDetails { get; set; }
    }
}
