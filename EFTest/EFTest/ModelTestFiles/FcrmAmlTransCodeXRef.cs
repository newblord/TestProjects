namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FcrmAmlTransCodeXRef")]
    public partial class FcrmAmlTransCodeXRef
    {
        [Key]
        public int FCRM_AML_TRANS_CODE_XREF_KEY { get; set; }

        public int FCRM_AML_TRANS_CODE_KEY { get; set; }

        public int TRANS_CODE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual FcrmAmlTransCode FcrmAmlTransCode { get; set; }
    }
}
