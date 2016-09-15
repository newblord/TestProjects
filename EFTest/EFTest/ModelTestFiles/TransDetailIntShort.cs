namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransDetailIntShort")]
    public partial class TransDetailIntShort
    {
        [Key]
        [Column(Order = 0)]
        public int TRANS_DETAIL_INT_SHORT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BUSINESS_DATE { get; set; }

        [Required]
        [StringLength(240)]
        public string TD_DESCRIPTION { get; set; }

        [Required]
        [StringLength(50)]
        public string SPELL_TRANS_CODE { get; set; }
    }
}
