namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerFlashResponse")]
    public partial class CustomerFlashResponse
    {
        [Key]
        public long CUSTOMER_FLASH_RESPONSE_KEY { get; set; }

        public byte CUSTOMER_FLASH_QUESTIONS_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public short RESPONSE { get; set; }

        public bool IS_NEW { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
