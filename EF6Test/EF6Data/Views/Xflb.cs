namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xflb")]
    public partial class Xflb
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flbkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_BATCH_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime BATCH_DATE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string UPLOAD_OR_DOWNLOAD { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IS_AD_ASTRA { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte FORM_LETTER_BATCH_STATUS_KEY { get; set; }

        public DateTime? BATCH_STATUS_DATETIME { get; set; }

        public byte? BATCH_STEP { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string X { get; set; }

        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [StringLength(15)]
        public string LSTNAME { get; set; }

        public int? PRINTED_LETTERS { get; set; }
    }
}
