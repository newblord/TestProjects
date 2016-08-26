namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLeadGen")]
    public partial class WebLeadGen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebLeadGen()
        {
            WebLeads = new HashSet<WebLead>();
            WebLeadGenAddresses = new HashSet<WebLeadGenAddress>();
            WebLeadGenFields = new HashSet<WebLeadGenField>();
            WebLeadGenStatistics = new HashSet<WebLeadGenStatistic>();
            WebLeadGenTiers = new HashSet<WebLeadGenTier>();
            WebLeadGenTranslations = new HashSet<WebLeadGenTranslation>();
        }

        [Key]
        public int Web_Lead_Gen_Key { get; set; }

        [Required]
        [StringLength(512)]
        public string Name { get; set; }

        public int? Attributes { get; set; }

        [StringLength(50)]
        public string ScoringModel { get; set; }

        public int? ColorCode { get; set; }

        public int? HourlyLimit { get; set; }

        public int? DailyLimit { get; set; }

        [StringLength(512)]
        public string WebsiteUrl { get; set; }

        public DateTime Date_Entered { get; set; }

        public DateTime Date_Updated { get; set; }

        public int? Lead_Post_Days { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLead> WebLeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLeadGenAddress> WebLeadGenAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLeadGenField> WebLeadGenFields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLeadGenStatistic> WebLeadGenStatistics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLeadGenTier> WebLeadGenTiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLeadGenTranslation> WebLeadGenTranslations { get; set; }
    }
}
