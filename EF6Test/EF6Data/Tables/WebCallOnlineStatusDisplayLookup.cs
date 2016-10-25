namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallOnlineStatusDisplayLookup")]
    public partial class WebCallOnlineStatusDisplayLookup
    {
        [Key]
        public int Online_Status_Key { get; set; }

        [Required]
        [StringLength(200)]
        public string Online_Status_Value { get; set; }

        [Required]
        [StringLength(200)]
        public string Online_Status_Display { get; set; }
    }
}
