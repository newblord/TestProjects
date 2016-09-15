namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Ach_Trecs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string RecordType { get; set; }

        [StringLength(52)]
        public string ImportAcct { get; set; }

        [StringLength(8)]
        public string PostDate { get; set; }

        [StringLength(8)]
        public string EffectiveDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string TransactionType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string DebitCredit { get; set; }

        [StringLength(50)]
        public string Amount { get; set; }

        [StringLength(52)]
        public string Reference1 { get; set; }

        [StringLength(50)]
        public string Reference2 { get; set; }

        [StringLength(50)]
        public string Reference3 { get; set; }

        [StringLength(50)]
        public string Reference4 { get; set; }

        [StringLength(50)]
        public string Reference5 { get; set; }

        [StringLength(50)]
        public string Details { get; set; }

        [StringLength(50)]
        public string Reference6 { get; set; }

        [StringLength(50)]
        public string Reference7 { get; set; }

        [StringLength(50)]
        public string Reference8 { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime BUSINESS_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRECS_EXPORT { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }
    }
}
