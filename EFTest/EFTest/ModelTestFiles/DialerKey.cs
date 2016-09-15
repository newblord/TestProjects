namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DialerKey
    {
        public int? rikey { get; set; }

        [StringLength(20)]
        public string reference { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? date { get; set; }

        [StringLength(100)]
        public string jobname { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? balance { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? balancetest { get; set; }

        public bool? Exclude { get; set; }

        public bool? Exported { get; set; }

        public short? ris_audit_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Followup { get; set; }

        public bool? COURTESY_EXPORT { get; set; }

        [Key]
        public int DIALER_KEYS_KEY { get; set; }

        public bool ExportedToNoble { get; set; }
    }
}
