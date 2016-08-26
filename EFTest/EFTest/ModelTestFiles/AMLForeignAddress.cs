namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AMLForeignAddress")]
    public partial class AMLForeignAddress
    {
        [Key]
        public int AML_FOREIGN_ADDRESS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(75)]
        public string ADDRESS1 { get; set; }

        [Required]
        [StringLength(75)]
        public string ADDRESS2 { get; set; }

        [Required]
        [StringLength(75)]
        public string ADDRESS3 { get; set; }

        public int COUNTRY_KEY { get; set; }

        [Required]
        [StringLength(12)]
        public string PHONE_NUMBER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual Country Country { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
