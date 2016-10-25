namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerUploadHistory")]
    public partial class WebDialerUploadHistory
    {
        [Key]
        public int WEB_DIALER_UPLOAD_HISTORY_KEY { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        public DateTime? WORK_ITEM_DATE_ENTERED { get; set; }

        public int PRIORITY { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [StringLength(50)]
        public string CELL_PHONE { get; set; }

        [StringLength(50)]
        public string HOME_PHONE { get; set; }

        [StringLength(50)]
        public string WORK_PHONE { get; set; }

        [StringLength(3)]
        public string UPLOAD_OPERATION { get; set; }

        public DateTime UPLOAD_DATE { get; set; }

        public virtual WebCallQueue WebCallQueue { get; set; }
    }
}
