namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOStatusHistory")]
    public partial class MOStatusHistory
    {
        [StringLength(100)]
        public string Error { get; set; }

        [StringLength(50)]
        public string MONumber { get; set; }

        public byte PrinterNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string Teller { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public short StatusCode { get; set; }

        public DateTime SubmitTime { get; set; }

        public short Location { get; set; }

        [Key]
        public int SequenceNo { get; set; }

        [Required]
        [StringLength(15)]
        public string TELLER_FIRSTNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string TELLER_LASTNAME { get; set; }
    }
}
