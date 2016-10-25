namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeritecLoanID")]
    public partial class VeritecLoanID
    {
        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string TRANS_NUM { get; set; }

        public bool MANUALLY_ENTERED { get; set; }

        [Key]
        public int VERITEC_LOAN_ID_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }
    }
}
