namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnCheckFile")]
    public partial class ReturnCheckFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReturnCheckFile()
        {
            ReturnCheckDetails = new HashSet<ReturnCheckDetail>();
        }

        [Key]
        public int RETURN_CHECK_FILE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int CURRENCY_KEY { get; set; }

        public int FILE_CREATION_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime FILE_CREATION_DATE { get; set; }

        public int TOTAL_RECORDS { get; set; }

        public decimal TOTAL_CHARGEBACKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnCheckDetail> ReturnCheckDetails { get; set; }
    }
}
