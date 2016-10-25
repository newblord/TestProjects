namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerDocument")]
    public partial class CustomerDocument
    {
        [Key]
        public int CUSTOMER_DOCUMENT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        public int DWDOCID { get; set; }

        public byte DOCUMENT_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string IGNORE_TELLER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IGNORE_DATE { get; set; }

        [StringLength(1)]
        public string IGNORE_TYPE { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
