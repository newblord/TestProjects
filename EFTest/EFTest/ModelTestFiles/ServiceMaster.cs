namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceMaster")]
    public partial class ServiceMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceMaster()
        {
            ServiceDetails = new HashSet<ServiceDetail>();
            ServiceSubItems = new HashSet<ServiceSubItem>();
            ServiceSubItems1 = new HashSet<ServiceSubItem>();
        }

        [Key]
        public int SERVICE_MASTER_KEY { get; set; }

        public byte SERVICE_NUM { get; set; }

        [Required]
        [StringLength(50)]
        public string SERVICE_NAME { get; set; }

        public byte DISPLAY_ORDER { get; set; }

        public bool INVENTORIED { get; set; }

        [Required]
        [StringLength(2)]
        public string FUNCTION_AS { get; set; }

        public bool REQUIRE_CUST { get; set; }

        public bool PAYOUT { get; set; }

        public bool QTY_PROMPT { get; set; }

        public bool AMT_PROMPT { get; set; }

        public bool FEE_PROMPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public bool CASH_ONLY { get; set; }

        public bool IS_TRACKED { get; set; }

        public bool IS_PREPAID { get; set; }

        public bool IS_TAXABLE { get; set; }

        public bool IS_AUTO_INVENTORY { get; set; }

        public bool IS_SUBITEM { get; set; }

        public bool IS_INDEPENDENT { get; set; }

        public bool REQ_CUST_PHONE { get; set; }

        public bool REQ_CUST_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceSubItem> ServiceSubItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceSubItem> ServiceSubItems1 { get; set; }
    }
}
