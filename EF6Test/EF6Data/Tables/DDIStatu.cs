namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DDIStatu
    {
        [Key]
        public int DDI_STATUS_KEY { get; set; }

        public int STATUS_CODE { get; set; }

        [StringLength(50)]
        public string DISPLAY { get; set; }

        [Required]
        [StringLength(200)]
        public string CODE_DESCRIPTION { get; set; }
    }
}
