namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Issuer")]
    public partial class Issuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Issuer()
        {
            IssuerEdits = new HashSet<IssuerEdit>();
            OptPlusCardDetails = new HashSet<OptPlusCardDetail>();
            RbcEFundBatchDetails = new HashSet<RbcEFundBatchDetail>();
            RISREPTs = new HashSet<RISREPT>();
        }

        [Key]
        public int ISSUER_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TLR { get; set; }

        public short LOCATION { get; set; }

        [Column("ISSUER")]
        [Required]
        [StringLength(50)]
        public string ISSUER1 { get; set; }

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
        [StringLength(12)]
        public string PHONE { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCT_NO { get; set; }

        [Required]
        [StringLength(9)]
        public string BANK_ID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LIMIT { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

        public bool BOUNCED { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        [StringLength(3)]
        public string TUPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TUPD { get; set; }

        public short? TLOC { get; set; }

        public bool BLOCK_CHECK { get; set; }

        public int? BANK_STATUS_ID { get; set; }

        public bool ACH_BLOCK { get; set; }

        [StringLength(6)]
        public string PHONE_EXT { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS1 { get; set; }

        [Required]
        [StringLength(25)]
        public string COUNTY { get; set; }

        [Required]
        [StringLength(3)]
        public string COUNTRY { get; set; }

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

        public bool? FLASH { get; set; }

        public int? BLOCK_REASON_KEY { get; set; }

        public bool? SYSTEM_BLOCK { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long? ACCT_NO_NUM { get; set; }

        public virtual Bank_Status Bank_Status { get; set; }

        public virtual BANK BANK { get; set; }

        public virtual BlockReason BlockReason { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual US_States US_States { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuerEdit> IssuerEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusCardDetail> OptPlusCardDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RbcEFundBatchDetail> RbcEFundBatchDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISREPT> RISREPTs { get; set; }
    }
}
