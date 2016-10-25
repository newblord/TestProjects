namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESignLoan")]
    public partial class ESignLoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        public byte[] DOCUMENT { get; set; }

        public byte ESIGN_STATUS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public bool IS_SUBMITTED { get; set; }

        [StringLength(500)]
        public string SUBMIT_ERROR { get; set; }

        public virtual ESignLoanStatu ESignLoanStatu { get; set; }
    }
}
