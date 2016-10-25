namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [Key]
        [Column(Order = 0)]
        public byte serv_num { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string serv_name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smallmoney")]
        public decimal serv_fee { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smallmoney")]
        public decimal serv_flat_chg { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int serv_type { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool serv_drw { get; set; }

        public int? serv_glacct { get; set; }

        public int? serv_glacct_amt { get; set; }

        public int? serv_glacct_fee { get; set; }

        public int? serv_cost_glacct { get; set; }

        public int? serv_profit_glacct { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short location { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Serv_Taxable { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int serv_tax_pct { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal Cost { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte OrderBy { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool RemoveList { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal MAX_CHARGE { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERVICE_KEY { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool REQUIRE_CUST { get; set; }
    }
}
