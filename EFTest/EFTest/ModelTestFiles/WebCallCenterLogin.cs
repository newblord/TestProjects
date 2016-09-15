namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallCenterLogin")]
    public partial class WebCallCenterLogin
    {
        [Key]
        public int CallCenter_Login_Key { get; set; }

        [Required]
        [StringLength(3)]
        public string Teller { get; set; }

        [Required]
        [StringLength(255)]
        public string Server { get; set; }

        public DateTime Login_Date { get; set; }

        public DateTime? Logout_Date { get; set; }

        public bool LoggedIn { get; set; }
    }
}
