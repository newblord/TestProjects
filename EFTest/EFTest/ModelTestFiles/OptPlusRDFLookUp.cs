namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusRDFLookUp")]
    public partial class OptPlusRDFLookUp
    {
        [StringLength(1)]
        public string RDF_CODE { get; set; }

        [StringLength(30)]
        public string FIELD_NAME { get; set; }

        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string RDF_FILE { get; set; }

        [Key]
        public int LOOKUP_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }
    }
}
