namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAYROLL1
    {
        [Required]
        [StringLength(1)]
        public string chk_type { get; set; }

        [Column(TypeName = "money")]
        public decimal PRICE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RATE { get; set; }

        public short Location { get; set; }

        [Key]
        public int Payroll1_key { get; set; }
    }
}
