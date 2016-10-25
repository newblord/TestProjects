namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusRDFAccountCard")]
    public partial class OptPlusRDFAccountCard
    {
        [StringLength(15)]
        public string PROGRAM_ID { get; set; }

        [StringLength(15)]
        public string GROUP_ID { get; set; }

        [StringLength(15)]
        public string PRODUCT_ID { get; set; }

        [StringLength(30)]
        public string ACCOUNT_ID { get; set; }

        [StringLength(12)]
        public string PRN { get; set; }

        [StringLength(8)]
        public string EXP_DATE { get; set; }

        [StringLength(5)]
        public string STATUS { get; set; }

        [StringLength(30)]
        public string CARD_ID { get; set; }

        [StringLength(16)]
        public string CARD_NUMBER { get; set; }

        [StringLength(10)]
        public string CARD_TYPE { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        public int ACCOUNT_CARD_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
