namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAddress")]
    public partial class CustomerAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAddress()
        {
            CustomerAddressEdits = new HashSet<CustomerAddressEdit>();
            CustomerEmployers = new HashSet<CustomerEmployer>();
            FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            FormLetterResults = new HashSet<FormLetterResult>();
        }

        [Key]
        public int CUSTOMER_ADDRESS_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public byte ADDRESS_TYPE_CODE { get; set; }

        public byte ADDRESS_SOURCE_CODE { get; set; }

        public byte ADDRESS_STATUS_CODE { get; set; }

        public short ADDRESS_PRIORITY { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS_CONTACT_LAST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS_CONTACT_FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

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

        [Required]
        [StringLength(10)]
        public string ADDR_NUM { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_PRE_DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUFFIX { get; set; }

        [Required]
        [StringLength(2)]
        public string ADDR_POST_DIR { get; set; }

        [Required]
        [StringLength(10)]
        public string ADDR_SUITE { get; set; }

        [Required]
        [StringLength(15)]
        public string ADDR_SUITE_NUM { get; set; }

        public DateTime LAST_UPDATED { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FROM_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TO_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(50)]
        public string FLAT_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string BUILDING_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string BUILDING_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_3 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string ADDRESS_LINE_2 { get; set; }

        public byte? REMOVED_REASON_KEY { get; set; }

        [StringLength(2000)]
        public string REMOVED_REASON_NOTES { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RemovedReason RemovedReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddressEdit> CustomerAddressEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEmployer> CustomerEmployers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterResult> FormLetterResults { get; set; }
    }
}
