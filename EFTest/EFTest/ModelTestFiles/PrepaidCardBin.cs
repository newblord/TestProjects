namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardBin")]
    public partial class PrepaidCardBin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardBin()
        {
            OptPlusBinProducts = new HashSet<OptPlusBinProduct>();
            OptPlusExportInitGLs = new HashSet<OptPlusExportInitGL>();
            OptPlusGlobals = new HashSet<OptPlusGlobal>();
            PrepaidCardBinCompanies = new HashSet<PrepaidCardBinCompany>();
        }

        [Key]
        public int PREPAID_CARD_BIN_KEY { get; set; }

        [Required]
        [StringLength(6)]
        public string BIN_NUMBER { get; set; }

        [Required]
        [StringLength(300)]
        public string BIN_DESCRIPTION { get; set; }

        public byte CARD_BRAND { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_TERMINATED { get; set; }

        public byte CARD_TYPE { get; set; }

        [StringLength(9)]
        public string ROUTING_NO { get; set; }

        public byte ID_VERIFY_METHOD { get; set; }

        [Required]
        [StringLength(50)]
        public string BIN_BANKNAME { get; set; }

        public int? WS_CONFIG_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusBinProduct> OptPlusBinProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusExportInitGL> OptPlusExportInitGLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusGlobal> OptPlusGlobals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompanies { get; set; }
    }
}
