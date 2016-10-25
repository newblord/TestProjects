namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANKS")]
    public partial class BANK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANK()
        {
            ACHQueues = new HashSet<ACHQueue>();
            BankClassifications = new HashSet<BankClassification>();
            Issuers = new HashSet<Issuer>();
        }

        [Key]
        [StringLength(9)]
        public string BANKABA { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(30)]
        public string BRANCH { get; set; }

        [StringLength(3)]
        public string AREACODE { get; set; }

        [StringLength(15)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string RIPHONE { get; set; }

        public bool MainBank { get; set; }

        [StringLength(12)]
        public string Verify_Phone { get; set; }

        [StringLength(12)]
        public string bankphone { get; set; }

        public byte? BANK_GROUP { get; set; }

        [StringLength(50)]
        public string BANK_REPORT_NOTE { get; set; }

        [Required]
        [StringLength(100)]
        public string BUSINESS_OPENS_AT { get; set; }

        public int? BANKS_PARENT_KEY { get; set; }

        public DateTime? DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? FED_UPDATE_DATE { get; set; }

        public bool AUTOMATED_MERCHANT_LINE { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS1 { get; set; }

        [Required]
        [StringLength(30)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string ZIPCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(30)]
        public string BANKCITY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(2)]
        public string BANKSTATE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(10)]
        public string BANKZIP { get; set; }

        public byte BANK_FUNDING_METHOD { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [Required]
        [StringLength(40)]
        public string ADDR_STREET { get; set; }

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

        public bool IS_GOVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHQueue> ACHQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankClassification> BankClassifications { get; set; }

        public virtual BanksParent BanksParent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuer> Issuers { get; set; }
    }
}
