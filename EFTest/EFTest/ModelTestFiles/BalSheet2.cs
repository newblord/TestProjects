namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BalSheet2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BalSheet2()
        {
            BalSheet_TransDetail = new HashSet<BalSheet_TransDetail>();
            BalSheetColumns2 = new HashSet<BalSheetColumns2>();
            EndOfDayRpts = new HashSet<EndOfDayRpt>();
        }

        [Key]
        public int BALSHEET_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime BUSINESS_DATE { get; set; }

        public bool EXPORTED { get; set; }

        public bool? TRECS_EXPORT { get; set; }

        public bool? ADASTRA_EXPORTED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BalSheet_TransDetail> BalSheet_TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BalSheetColumns2> BalSheetColumns2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EndOfDayRpt> EndOfDayRpts { get; set; }
    }
}
