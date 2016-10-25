namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnCheckDetail")]
    public partial class ReturnCheckDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReturnCheckDetail()
        {
            ReturnCheckMatches = new HashSet<ReturnCheckMatch>();
        }

        [Key]
        public int RETURN_CHECK_DETAIL_KEY { get; set; }

        public int RETURN_CHECK_FILE_KEY { get; set; }

        [Required]
        [StringLength(9)]
        public string BANK_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCT_NO { get; set; }

        public decimal CHARGEBACK_AMT { get; set; }

        [StringLength(25)]
        public string CUSTOMER_NUMBER { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSTOMER_NAME { get; set; }

        public int CURRENCY_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime ORIGINAL_DEPOSIT_DATE { get; set; }

        [StringLength(12)]
        public string PARSED_LOCATION { get; set; }

        [Required]
        [StringLength(10)]
        public string SEQUENCE_NUMBER { get; set; }

        [Required]
        [StringLength(3)]
        public string RETURN_REASON_CODE { get; set; }

        public virtual ReturnCheckFile ReturnCheckFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnCheckMatch> ReturnCheckMatches { get; set; }
    }
}
