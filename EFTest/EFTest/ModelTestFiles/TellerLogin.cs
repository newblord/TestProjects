namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TellerLogin")]
    public partial class TellerLogin
    {
        [Key]
        public int TELLER_LOGIN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(255)]
        public string HOSTNAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime LOGIN_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LOGOUT_DATE { get; set; }

        public bool LOGGED_IN { get; set; }

        [Required]
        [StringLength(50)]
        public string SERVER_NAME { get; set; }
    }
}
