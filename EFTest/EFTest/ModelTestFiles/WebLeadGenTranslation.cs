namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebLeadGenTranslation
    {
        public int Web_Lead_Gen_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        public int Field { get; set; }

        public int Translation { get; set; }

        [Key]
        public int WEB_LEAD_GEN_TRANSLATIONS_KEY { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
