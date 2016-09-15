namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerCreditRptDetail")]
    public partial class CustomerCreditRptDetail
    {
        [Key]
        public int CR_DETAIL_KEY { get; set; }

        public int CREDIT_RPT_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(4)]
        public string LINE_TYPE { get; set; }

        [Required]
        [StringLength(288)]
        public string LINE_TEXT { get; set; }

        public short LINE_ORDER { get; set; }

        public virtual CustomerCreditRpt CustomerCreditRpt { get; set; }
    }
}
