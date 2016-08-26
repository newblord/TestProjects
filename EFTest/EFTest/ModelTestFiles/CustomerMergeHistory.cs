namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMergeHistory")]
    public partial class CustomerMergeHistory
    {
        [Key]
        public int CUSTOMER_MERGE_HISTORY_KEY { get; set; }

        public int DELETED_CUST_PKEY { get; set; }

        public int MERGED_INTO_CUST_PKEY { get; set; }

        public DateTime DATE_ENTERED_WITH_SECONDS { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }
    }
}
