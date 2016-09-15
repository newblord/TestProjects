namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanCoPledger")]
    public partial class LoanCoPledger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanCoPledger()
        {
            TitleLoans = new HashSet<TitleLoan>();
        }

        [Key]
        public int LOAN_CO_PLEDGER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string GENDER { get; set; }

        public byte HEIGHT_FEET { get; set; }

        public byte HEIGHT_INCHES { get; set; }

        public byte RACE { get; set; }

        public byte EYE_COLOR { get; set; }

        public byte HAIR_COLOR { get; set; }

        [Required]
        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OF_BIRTH { get; set; }

        [Required]
        [StringLength(25)]
        public string PHOTO_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string PHOTO_ID_TYPE { get; set; }

        [Required]
        [StringLength(15)]
        public string ISSUING_AGENCY { get; set; }

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

        [StringLength(9)]
        public string SSN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleLoan> TitleLoans { get; set; }
    }
}
