namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdAstraWebInventory")]
    public partial class AdAstraWebInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RISREPT_KEY { get; set; }

        [StringLength(43)]
        public string REFERENCE { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(24)]
        public string FIRSTNAME { get; set; }

        [StringLength(25)]
        public string LASTNAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public bool IS_ELIGIBLE { get; set; }

        public int? RIS_AUDIT_ID { get; set; }
    }
}
