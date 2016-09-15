namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebVisit")]
    public partial class WebVisit
    {
        [Key]
        public long WEB_VISIT_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime DATE_SESSION_END { get; set; }

        [StringLength(2085)]
        public string USER_AGENT { get; set; }

        [Required]
        [StringLength(15)]
        public string IP_ADDRESS { get; set; }

        [StringLength(2083)]
        public string DESTINATION_URL { get; set; }

        [StringLength(50)]
        public string DESTINATION_DOMAIN { get; set; }

        public bool IS_SECURE_URL { get; set; }

        [Required]
        [StringLength(2085)]
        public string SOURCE_URL { get; set; }

        [StringLength(100)]
        public string SOURCE_DOMAIN { get; set; }

        [StringLength(500)]
        public string SEARCH_QUERY { get; set; }

        [StringLength(500)]
        public string KEYWORDS { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string LINK_TYPE { get; set; }

        [StringLength(50)]
        public string VENDOR { get; set; }

        [StringLength(50)]
        public string CHANNEL { get; set; }

        [StringLength(50)]
        public string SUB_CHANNEL { get; set; }

        [StringLength(50)]
        public string CAMPAIGN { get; set; }

        [StringLength(50)]
        public string CONTENT { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
