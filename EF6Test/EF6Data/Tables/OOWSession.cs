namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OOWSession")]
    public partial class OOWSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OOWSession()
        {
            OOWSessionAlerts = new HashSet<OOWSessionAlert>();
            OOWSessionErrors = new HashSet<OOWSessionError>();
            OOWSessionQuestions = new HashSet<OOWSessionQuestion>();
        }

        [Key]
        public int OOW_SESSION_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        public int SESSION_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string EXTERNAL_ID { get; set; }

        public int? EARNED_POINTS { get; set; }

        public int? POSSIBLE_POINTS { get; set; }

        public int? TRANSUNION_CONFIDENCE_SCORE { get; set; }

        [StringLength(20)]
        public string TRANSUNION_DECISION { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOWSessionAlert> OOWSessionAlerts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOWSessionError> OOWSessionErrors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOWSessionQuestion> OOWSessionQuestions { get; set; }
    }
}
