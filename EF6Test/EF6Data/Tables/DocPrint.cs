namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocPrint")]
    public partial class DocPrint
    {
        [Key]
        public int DOCPRINT_KEY { get; set; }

        public int DOCTEMPLATE_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DOC_DATA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }
    }
}
