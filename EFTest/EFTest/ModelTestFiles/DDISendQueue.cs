namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDISendQueue")]
    public partial class DDISendQueue
    {
        [Key]
        public int DDI_SEND_QUEUE_KEY { get; set; }

        public int DDI_KEY { get; set; }

        [Required]
        [StringLength(9)]
        public string SORT_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCOUNT_NUMBER { get; set; }

        [Required]
        [StringLength(18)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(18)]
        public string REFERENCE { get; set; }

        [Required]
        [StringLength(2)]
        public string TRANS_CODE { get; set; }

        [Required]
        [StringLength(18)]
        public string STATUS { get; set; }

        [Required]
        [StringLength(18)]
        public string ORIGINATOR { get; set; }

        [Required]
        [StringLength(3)]
        public string SENT_BY { get; set; }

        public DateTime ENTERED_DATE { get; set; }

        public int LOAN_KEY { get; set; }

        public virtual DDI DDI { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
