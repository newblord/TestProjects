namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebSiteEvent")]
    public partial class WebSiteEvent
    {
        [Key]
        public int WEB_SITE_EVENT_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        [StringLength(500)]
        public string EVENT_NAME { get; set; }

        [StringLength(2000)]
        public string COMMENTS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }
    }
}
