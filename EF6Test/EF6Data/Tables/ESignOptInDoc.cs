namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESignOptInDoc")]
    public partial class ESignOptInDoc
    {
        [Key]
        public int ESIGN_OPT_IN_DOC_KEY { get; set; }

        public string DOC_XML { get; set; }

        [StringLength(1)]
        public string LANGUAGE { get; set; }

        [StringLength(50)]
        public string DOC_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }
    }
}
