namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestCreditCard")]
    public partial class TestCreditCard
    {
        [Key]
        public int TEST_CREDIT_CARD_KEY { get; set; }

        [Required]
        [StringLength(16)]
        public string CARD_NUMBER { get; set; }

        public bool VISA { get; set; }

        public bool MC { get; set; }

        public bool IN_USE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? GUARANTEE_AMT { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        public int TestScenario { get; set; }
    }
}
