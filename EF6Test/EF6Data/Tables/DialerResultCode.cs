namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DialerResultCode
    {
        [Key]
        public int Dialer_Results_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Result_Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int? Speedy_Result_Code { get; set; }
    }
}
