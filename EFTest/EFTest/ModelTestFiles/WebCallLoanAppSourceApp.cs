namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallLoanAppSourceApp")]
    public partial class WebCallLoanAppSourceApp
    {
        [Key]
        [StringLength(1)]
        public string Source_App_Key { get; set; }

        [Required]
        [StringLength(200)]
        public string Source_App_Description { get; set; }
    }
}
