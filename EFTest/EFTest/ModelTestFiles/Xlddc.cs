namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlddc")]
    public partial class Xlddc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lddckey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DUEDATE_CHANGE_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IS_DUEDATE_CHANGED { get; set; }

        public int? LOAN_CHECK_KEY { get; set; }

        [StringLength(50)]
        public string CHANGE_NOTE { get; set; }

        public int? OPEN_END_LOAN_STMT_KEY { get; set; }
    }
}
