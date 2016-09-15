namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WireTransferFileImport")]
    public partial class WireTransferFileImport
    {
        [Key]
        public int WIRE_TRANSFER_FILE_IMPORT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IMPORT_DATE { get; set; }

        [Required]
        [StringLength(50)]
        public string IMPORT_PROCESS { get; set; }

        [Required]
        [StringLength(100)]
        public string WIRE_TRANSFER_FILE_NAME { get; set; }

        public int? RUN_MASTER_KEY { get; set; }
    }
}
