namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallCatRarrAlia
    {
        [Key]
        public int Web_Call_CatRarrAlias_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias_Name { get; set; }

        public int Web_Call_Category_Key { get; set; }

        public int WEB_CALL_REASON_KEY { get; set; }

        public int WEB_CALL_ACTION_KEY { get; set; }

        public int WEB_CALL_RESULT1_KEY { get; set; }

        public int WEB_CALL_RESULT2_KEY { get; set; }

        public int WEB_CALL_RARR_KEY { get; set; }
    }
}
