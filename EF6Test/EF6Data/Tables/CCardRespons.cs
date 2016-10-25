namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CCardResponses")]
    public partial class CCardRespons
    {
        [Key]
        public int CCARD_RESPONSE_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        public byte RESPONSE { get; set; }

        public bool IS_NEW { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
