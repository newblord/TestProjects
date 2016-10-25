namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocuwareStatu
    {
        [Key]
        public int DOCUWARESTATUS_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOC_DATE { get; set; }

        public int LOCATION { get; set; }

        [StringLength(50)]
        public string DOC_TYPE { get; set; }

        [StringLength(3)]
        public string IGNORE_TELLER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IGNORE_DATE { get; set; }

        [StringLength(1)]
        public string IGNORE_TYPE { get; set; }

        public int? DWDOCID { get; set; }
    }
}
