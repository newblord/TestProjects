namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebLeadGenField
    {
        public int Web_Lead_Gen_Key { get; set; }

        public int Field { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        public int WEB_LEAD_GEN_FIELDS_KEY { get; set; }

        public virtual WebLeadGen WebLeadGen { get; set; }
    }
}
