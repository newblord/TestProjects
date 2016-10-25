namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_EosMoneyGrams
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string trx_lastname { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal svc_amount { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime trx_date { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(36)]
        public string tellername { get; set; }

        public DateTime? trans_date { get; set; }
    }
}
