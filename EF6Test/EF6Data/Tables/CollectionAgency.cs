namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectionAgency")]
    public partial class CollectionAgency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionAgency()
        {
            CollectionAgencyPcts = new HashSet<CollectionAgencyPct>();
            CpiuMasters = new HashSet<CpiuMaster>();
        }

        [Key]
        public int COLLECTION_AGENCY_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string AGENCY_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string AGENCY_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS1 { get; set; }

        [Required]
        [StringLength(40)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONE { get; set; }

        [Required]
        [StringLength(5)]
        public string PHONE_EXT { get; set; }

        [Required]
        [StringLength(40)]
        public string CONTACT_NAME { get; set; }

        public bool IS_ACTIVE { get; set; }

        public short MAX_DAYS_PCT_RANGE1 { get; set; }

        public short MAX_DAYS_PCT_RANGE2 { get; set; }

        public decimal PCT_RANGE1 { get; set; }

        public decimal PCT_RANGE2 { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        public bool IS_DMC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionAgencyPct> CollectionAgencyPcts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpiuMaster> CpiuMasters { get; set; }
    }
}
