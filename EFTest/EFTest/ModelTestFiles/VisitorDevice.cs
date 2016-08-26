namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitorDevice")]
    public partial class VisitorDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitorDevice()
        {
            PushNotifications = new HashSet<PushNotification>();
            VisitorApiAuthorizations = new HashSet<VisitorApiAuthorization>();
        }

        [Key]
        public int VISITOR_DEVICE_KEY { get; set; }

        [Required]
        [StringLength(250)]
        public string UUID { get; set; }

        [Required]
        [StringLength(500)]
        public string SUBSCRIPTION_TOKEN { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public int NUM_PUSH_ERRORS { get; set; }

        public int VISITOR_KEY { get; set; }

        public bool IS_EXPIRED { get; set; }

        public byte DEVICE_TYPE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public DateTime? DATE_LAST_PUSH { get; set; }

        [Required]
        [StringLength(20)]
        public string APPLICATION_VERSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PushNotification> PushNotifications { get; set; }

        public virtual Visitor Visitor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorizations { get; set; }
    }
}
