namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallQueueConfiguration")]
    public partial class WebCallQueueConfiguration
    {
        [Key]
        public int WEB_CALL_QUEUE_CONFIGURATION_KEY { get; set; }

        public int DEFAULT_ONLINE_REFRESH_RATE { get; set; }

        public int DEFAULT_TEST_USER_REFRESH_RATE { get; set; }

        public int DEFAULT_CUSTOMER_SUPPORT_REFRESH_RATE { get; set; }

        public int DEFAULT_SUMMARY_REFRESH_RATE { get; set; }

        public int FOLLOW_UP_DATE_HOUR_THRESHOLD { get; set; }

        public int FOLLOW_UP_DATE_MINUTE_THRESHOLD { get; set; }
    }
}
