namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoBankingReport")]
    public partial class AutoBankingReport
    {
        [Key]
        public int AUTOBANKINGREPORT_KEY { get; set; }

        public int EXTERNAL_APPS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [StringLength(43)]
        public string REFERENCE { get; set; }

        [StringLength(50)]
        public string ISSUER { get; set; }

        public short? LOCATION { get; set; }

        [StringLength(20)]
        public string ACCT { get; set; }

        [StringLength(9)]
        public string BANK_ABA { get; set; }

        [StringLength(10)]
        public string CHECK_NO { get; set; }

        [Column(TypeName = "money")]
        public decimal? AMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? BALANCE { get; set; }

        [StringLength(1)]
        public string AUDIT_CAT { get; set; }

        [Required]
        [StringLength(50)]
        public string RESULTS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RI_DATE { get; set; }
    }
}
