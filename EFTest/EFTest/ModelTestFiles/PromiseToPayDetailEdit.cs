namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromiseToPayDetailEdit")]
    public partial class PromiseToPayDetailEdit
    {
        [Key]
        public int PROMISE_TO_PAY_DETAIL_EDIT_KEY { get; set; }

        public int PTP_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string DML_TYPE { get; set; }

        [Required]
        [StringLength(40)]
        public string FIELD_NAME { get; set; }

        [StringLength(50)]
        public string OLD_VALUE { get; set; }

        [StringLength(50)]
        public string NEW_VALUE { get; set; }

        public virtual PromiseToPayDetail PromiseToPayDetail { get; set; }
    }
}
