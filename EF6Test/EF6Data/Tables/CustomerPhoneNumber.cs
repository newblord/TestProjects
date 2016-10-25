namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerPhoneNumber")]
    public partial class CustomerPhoneNumber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerPhoneNumber()
        {
            CustomerEmployers = new HashSet<CustomerEmployer>();
            CustomerPhoneNumberEdits = new HashSet<CustomerPhoneNumberEdit>();
        }

        [Key]
        public int CUSTOMER_PHONE_NUMBER_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public byte PHONE_TYPE_CODE { get; set; }

        public byte PHONE_SOURCE_CODE { get; set; }

        public byte PHONE_STATUS_CODE { get; set; }

        public short PHONE_PRIORITY { get; set; }

        [StringLength(50)]
        public string PHONE_CONTACT_LAST_NAME { get; set; }

        [StringLength(50)]
        public string PHONE_CONTACT_FIRST_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string PHONE_NUMBER { get; set; }

        [StringLength(10)]
        public string PHONE_EXT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_LAST_USED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? STATUS_CHANGE_DATE { get; set; }

        [StringLength(3)]
        public string STATUS_CHANGE_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRIORITY_CHANGE_DATE { get; set; }

        [StringLength(3)]
        public string PRIORITY_CHANGE_TELLER { get; set; }

        public byte TIMES_USED { get; set; }

        public DateTime LAST_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        public bool? CALL_CENTER_DO_NOT_CALL { get; set; }

        public DateTime? CALL_CENTER_DO_NOT_CALL_UNTIL { get; set; }

        public DateTime? CALL_CENTER_DO_NOT_CALL_CHANGE_DATE { get; set; }

        [StringLength(3)]
        public string CALL_CENTER_DO_NOT_CALL_CHANGE_TELLER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AUTO_DIAL_CONSENT_MODIFICATION_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PHYSICAL_CELL_NUMBER_LAST_CHECKED_DATE { get; set; }

        public bool? HAS_AUTO_DIAL_CONSENT { get; set; }

        public bool? IS_PHYSICAL_CELL_NUMBER { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEmployer> CustomerEmployers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPhoneNumberEdit> CustomerPhoneNumberEdits { get; set; }
    }
}
