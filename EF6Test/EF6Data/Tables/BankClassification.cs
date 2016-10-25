namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankClassification")]
    public partial class BankClassification
    {
        [Key]
        public int BANK_CLASSIFICATION_KEY { get; set; }

        [Required]
        [StringLength(9)]
        public string BANKABA { get; set; }

        public int BANK_CLASSIFICATION_TYPE_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual BankClassificationType BankClassificationType { get; set; }

        public virtual BANK BANK { get; set; }
    }
}
