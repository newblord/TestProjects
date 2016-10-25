namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerComputer")]
    public partial class TellerComputer
    {
        [Key]
        public int TELLER_COMPUTER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(20)]
        public string COMPUTER_NAME { get; set; }
    }
}
