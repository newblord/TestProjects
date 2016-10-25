namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xsm")]
    public partial class Xsm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_MASTER_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte SERVICE_NUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte DISPLAY_ORDER { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool INVENTORIED { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string FUNCTION_AS { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool REQUIRE_CUST { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool PAYOUT { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool QTY_PROMPT { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool AMT_PROMPT { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool FEE_PROMPT { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool CASH_ONLY { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IS_TRACKED { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool IS_PREPAID { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool IS_TAXABLE { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IS_AUTO_INVENTORY { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IS_SUBITEM { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IS_INDEPENDENT { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SMKEY { get; set; }
    }
}
