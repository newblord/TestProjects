namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebAlert")]
    public partial class WebAlert
    {
        [Key]
        [Column(Order = 0)]
        public int WebAlertKey { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "xml")]
        public string AlertText { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Enabled { get; set; }

        public DateTime? Date_Entered { get; set; }

        public DateTime? Date_Last_Updated { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string Created_By { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string Last_Updated_By { get; set; }
    }
}
