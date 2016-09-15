namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckAgain")]
    public partial class CheckAgain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckAgain()
        {
            CheckAgainHistories = new HashSet<CheckAgainHistory>();
        }

        [Key]
        public int CHECKAGAIN_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public bool SENT { get; set; }

        public virtual Loan Loan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckAgainHistory> CheckAgainHistories { get; set; }
    }
}
