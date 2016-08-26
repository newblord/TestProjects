namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyDocumentResource")]
    public partial class CompanyDocumentResource
    {
        [Key]
        public int COMPANY_DOCUMENT_RESOURCE_KEY { get; set; }

        public short LOCATION { get; set; }

        public int DOCUMENT_RESOURCE_KEY { get; set; }

        [Required]
        [StringLength(30)]
        public string DOCUMENT_FIELD_NAME { get; set; }

        public virtual Company Company { get; set; }

        public virtual DocumentResource DocumentResource { get; set; }
    }
}
