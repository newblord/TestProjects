namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_LoansByStatus
    {
        [StringLength(25)]
        public string lastname { get; set; }

        [StringLength(24)]
        public string firstname { get; set; }

        [StringLength(51)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customer_key { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int curo_customer_key { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loan_key { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smallmoney")]
        public decimal loan_amt { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smallmoney")]
        public decimal loan_balance { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string loan_status { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime date_entered { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime loan_status_date { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string product_type { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string loan_type { get; set; }

        [StringLength(10)]
        public string StatusDescription { get; set; }
    }
}
