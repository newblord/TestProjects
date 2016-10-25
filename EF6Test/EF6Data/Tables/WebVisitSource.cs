namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebVisitSource")]
    public partial class WebVisitSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebVisitSource()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [StringLength(38)]
        public string SESSION_GUID { get; set; }

        [Required]
        [StringLength(2085)]
        public string SOURCE_URL { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        [StringLength(100)]
        public string DOMAIN { get; set; }

        [StringLength(500)]
        public string SEARCH_QUERY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime? SESSION_END { get; set; }

        [StringLength(2083)]
        public string DEST_URL { get; set; }

        [StringLength(50)]
        public string LINK_TYPE { get; set; }

        [StringLength(2085)]
        public string USER_AGENT { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(500)]
        public string KEY_WORDS { get; set; }

        [Required]
        [StringLength(15)]
        public string IP_ADDRESS { get; set; }

        public bool IS_SECURE_URL { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WebVisitSource_Key { get; set; }

        [StringLength(50)]
        public string CHANNEL { get; set; }

        [StringLength(50)]
        public string VENDOR { get; set; }

        [StringLength(50)]
        public string SUB_CHANNEL { get; set; }

        [StringLength(50)]
        public string CAMPAIGN { get; set; }

        [StringLength(50)]
        public string CONTENT { get; set; }

        [StringLength(50)]
        public string DEST_DOMAIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
