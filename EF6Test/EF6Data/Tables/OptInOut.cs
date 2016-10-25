namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptInOut")]
    public partial class OptInOut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptInOut()
        {
            OptInOutEdits = new HashSet<OptInOutEdit>();
        }

        [Key]
        public int OPTINOUT_KEY { get; set; }

        public int VISITOR_KEY { get; set; }

        public bool OPTOUT_TRANSACTION_COMMUNICATION { get; set; }

        public bool OPTOUT_THIRD_PARTY_SHARE { get; set; }

        public bool OPTOUT_EMAIL { get; set; }

        public bool OPTOUT_SMS { get; set; }

        public bool OPTOUT_VOICEBLAST { get; set; }

        public bool OPTOUT_CALL_CAMPAIGN { get; set; }

        public bool OPTOUT_DIRECT_MAIL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public bool OPTOUT_CR_SMS { get; set; }

        public bool OPTOUT_OPTPLUS_SMS { get; set; }

        public bool OPTOUT_OPTPLUS_VOICEBLAST { get; set; }

        public bool OPTOUT_OPTPLUS_CALL_CAMPAIGN { get; set; }

        public bool OPTOUT_OPTPLUS_EMAIL { get; set; }

        public bool OPTOUT_OPTPLUS_DIRECT_MAIL { get; set; }

        [Required]
        [StringLength(12)]
        public string SMS_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string VOICEBLAST_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string CALL_CAMPAIGN_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string OPTPLUS_SMS_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string OPTPLUS_VOICEBLAST_PHONE { get; set; }

        [Required]
        [StringLength(12)]
        public string OPTPLUS_CALL_CAMPAIGN_PHONE { get; set; }

        public bool OPTOUT_PRIVACY_CONSENT { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptInOutEdit> OptInOutEdits { get; set; }
    }
}
