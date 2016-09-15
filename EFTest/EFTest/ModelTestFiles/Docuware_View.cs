namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Docuware_View
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string BARCODE { get; set; }

        public int? LOANNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [StringLength(40)]
        public string CUSTNAME { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }

        [StringLength(20)]
        public string DRIVERSLIC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STORE_NO { get; set; }

        [StringLength(10)]
        public string LOANDATE { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime DUEDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_NO { get; set; }
    }
}
