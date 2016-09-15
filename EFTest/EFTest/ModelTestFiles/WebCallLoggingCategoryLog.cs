namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallLoggingCategoryLog")]
    public partial class WebCallLoggingCategoryLog
    {
        [Key]
        public int WEB_CALL_LOGGING_CATEGORY_LOG_KEY { get; set; }

        public int WEB_CALL_LOGGING_CATEGORY_KEY { get; set; }

        public int WEB_CALL_LOGGING_LOG_KEY { get; set; }

        public virtual WebCallLoggingCategory WebCallLoggingCategory { get; set; }

        public virtual WebCallLoggingLog WebCallLoggingLog { get; set; }
    }
}
