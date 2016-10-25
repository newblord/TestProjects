namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanStatusChange")]
    public partial class LoanStatusChange
    {
        [Key]
        public int LOAN_STATUS_CHANGE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string OLD_LOAN_STATUS { get; set; }

        [Required]
        [StringLength(1)]
        public string NEW_LOAN_STATUS { get; set; }

        public bool OLD_LOAN_DEFAULTED { get; set; }

        public bool NEW_LOAN_DEFAULTED { get; set; }

        [StringLength(1)]
        public string REASON_DEFAULTED { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }
    }
}
