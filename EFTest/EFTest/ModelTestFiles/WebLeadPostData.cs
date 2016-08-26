namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLeadPostData")]
    public partial class WebLeadPostData
    {
        public int Web_Lead_Key { get; set; }

        [Required]
        [StringLength(8000)]
        public string Form_Data { get; set; }

        public string Response_Data { get; set; }

        [StringLength(50)]
        public string Result { get; set; }

        public string Info { get; set; }

        public string Error { get; set; }

        public string Url { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        [Key]
        public int Web_Lead_Posted_Data_Key { get; set; }

        public DateTime? Date_Entered { get; set; }

        public short? ProcessTime { get; set; }

        public short? SCORING_TIME { get; set; }

        [StringLength(20)]
        public string APP_SERVER_NAME { get; set; }
    }
}
