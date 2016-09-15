namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallWorkItemCategoryHistory")]
    public partial class WebCallWorkItemCategoryHistory
    {
        [Key]
        public int WEB_CALL_WORK_ITEM_CATEGORY_HISTORY_KEY { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        public int WEB_CALL_CATEGORY_KEY { get; set; }

        public DateTime DATE_CREATED { get; set; }

        public virtual WebCallCategory WebCallCategory { get; set; }
    }
}
