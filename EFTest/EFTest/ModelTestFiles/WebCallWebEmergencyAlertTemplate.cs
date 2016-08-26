namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallWebEmergencyAlertTemplate")]
    public partial class WebCallWebEmergencyAlertTemplate
    {
        [Key]
        public int Web_Call_Web_Emergency_Alert_Template_Key { get; set; }

        [Required]
        [StringLength(500)]
        public string Scenario { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Alert_Template_Text { get; set; }

        public DateTime Date_Entered { get; set; }

        public DateTime Date_Last_Updated { get; set; }

        [Required]
        [StringLength(500)]
        public string Created_By { get; set; }

        [Required]
        [StringLength(500)]
        public string Last_Updated_By { get; set; }
    }
}
