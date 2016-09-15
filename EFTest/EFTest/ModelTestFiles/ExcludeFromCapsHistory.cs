namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExcludeFromCapsHistory")]
    public partial class ExcludeFromCapsHistory
    {
        [Key]
        public int EXCLUDE_FROM_CAPS_HISTORY_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public bool EXCLUDE_FROM_CAPS { get; set; }

        public bool EXCLUDE_FROM_CAPS_ACH { get; set; }

        [Required]
        [StringLength(250)]
        public string OPT_OUT_REASON { get; set; }

        public virtual Company Company { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
