namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Notes_Contacts
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime NOTEDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string DESCR { get; set; }

        [StringLength(600)]
        public string NOTETEXT { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal DOLLARAMOUNT { get; set; }

        [StringLength(36)]
        public string TELLERNAME { get; set; }

        [StringLength(43)]
        public string CUSTOM1 { get; set; }

        [StringLength(306)]
        public string CUSTOM2 { get; set; }

        public int? CUSTOM3 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RISREPT_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COLLECTION_ACTION_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IS_AD_ASTRA { get; set; }
    }
}
