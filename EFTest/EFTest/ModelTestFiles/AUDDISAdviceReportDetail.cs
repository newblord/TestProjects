namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDDISAdviceReportDetail")]
    public partial class AUDDISAdviceReportDetail
    {
        [Key]
        [Column(Order = 0)]
        public int AUDDIS_ADVICE_REPORT_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AUDDIS_ADVICE_REPORT_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(18)]
        public string AOSN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string REASON_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(9)]
        public string PAYER_SORT_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string PAYER_ACCOUNT_NUMBER { get; set; }

        [StringLength(9)]
        public string NEW_SORT_CODE { get; set; }

        [StringLength(20)]
        public string NEW_ACCOUNT_NUMBER { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(18)]
        public string LAST_NAME { get; set; }

        [StringLength(18)]
        public string REFERENCE { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime EFFECTIVE_DATE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string RECORD_TYPE { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IS_PROCESSED { get; set; }

        public virtual AUDDISAdviceReport AUDDISAdviceReport { get; set; }
    }
}
