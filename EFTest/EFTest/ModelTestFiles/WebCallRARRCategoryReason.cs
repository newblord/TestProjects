namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRARRCategoryReason")]
    public partial class WebCallRARRCategoryReason
    {
        [Key]
        public int WEB_CALL_RARR_CATEGORY_REASON_KEY { get; set; }

        public int WEB_CALL_CATEGORY_REASON_KEY { get; set; }

        public int WEB_CALL_RARR_REASON_KEY { get; set; }

        public virtual WebCallCategory WebCallCategory { get; set; }

        public virtual WebCallRARReason WebCallRARReason { get; set; }
    }
}
