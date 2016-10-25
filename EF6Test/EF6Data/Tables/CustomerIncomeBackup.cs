namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerIncomeBackup")]
    public partial class CustomerIncomeBackup
    {
        [Key]
        [Column(Order = 0)]
        public int CUSTOMER_INCOME_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string INCOME_TYPE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal INCOME_AMOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte INCOME_VERIFY_METHOD_KEY { get; set; }
    }
}
