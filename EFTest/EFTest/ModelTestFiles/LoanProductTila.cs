namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductTila")]
    public partial class LoanProductTila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanProductTila()
        {
            LoanApplicationProducts = new HashSet<LoanApplicationProduct>();
            LoanProductEnableNewLoans = new HashSet<LoanProductEnableNewLoan>();
        }

        [Key]
        public int LOAN_PRODUCT_TILA_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string TILA_ADDR_STREET { get; set; }

        [Required]
        [StringLength(50)]
        public string TILA_ADDRESS1 { get; set; }

        [Required]
        [StringLength(40)]
        public string TILA_BUILDING_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string TILA_BUILDING_NUM { get; set; }

        [Required]
        [StringLength(25)]
        public string TILA_CERT_NUM { get; set; }

        [Required]
        [StringLength(30)]
        public string TILA_CITY { get; set; }

        [Required]
        [StringLength(3)]
        public string TILA_COUNTRY { get; set; }

        [Required]
        [StringLength(25)]
        public string TILA_COUNTY { get; set; }

        [Required]
        [StringLength(50)]
        public string TILA_FLAT_NUM { get; set; }

        [Required]
        [StringLength(75)]
        public string TILA_NAME { get; set; }

        [Required]
        [StringLength(14)]
        public string TILA_PHONE { get; set; }

        [Required]
        [StringLength(2)]
        public string TILA_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string TILA_ZIPCODE { get; set; }

        [Required]
        [StringLength(3)]
        public string ADDRESS_FORMAT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string TILA_ADDRESS_CSZ { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string TILA_ADDRESS_LINE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(100)]
        public string TILA_ADDRESS_LINE_1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string TILA_ADDRESS_LINE_2 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(150)]
        public string TILA_ADDRESS_LINE_3 { get; set; }

        public short LOCATION { get; set; }

        public int LOANS_COUNT { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoans { get; set; }
    }
}
