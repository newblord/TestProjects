namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CpiuDetail")]
    public partial class CpiuDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CpiuDetail()
        {
            CpiuExceptionReports = new HashSet<CpiuExceptionReport>();
        }

        [Key]
        public int CPIU_DETAIL_KEY { get; set; }

        public int CPIU_MASTER_KEY { get; set; }

        [StringLength(40)]
        public string AGENCY_REFERENCE { get; set; }

        [StringLength(43)]
        public string REFERENCE { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public short? LOCATION { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime PAYMENT_DATE { get; set; }

        [StringLength(10)]
        public string CHECK_NO { get; set; }

        public bool POSTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? POSTED_DATETIME { get; set; }

        [StringLength(3)]
        public string POSTED_TELLER { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [StringLength(250)]
        public string ERROR_MSG { get; set; }

        public bool IS_PIF { get; set; }

        public bool IS_SIF { get; set; }

        [StringLength(100)]
        public string CLIENT_NAME { get; set; }

        [StringLength(100)]
        public string CLIENT_ADDRESS { get; set; }

        [StringLength(10)]
        public string CLIENT_POSTCODE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CLIENT_DOB { get; set; }

        public bool DO_NOT_POST { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DO_NOT_POST_DATETIME { get; set; }

        [StringLength(3)]
        public string DO_NOT_POST_TELLER { get; set; }

        public virtual CpiuMaster CpiuMaster { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuExceptionReport> CpiuExceptionReports { get; set; }
    }
}
