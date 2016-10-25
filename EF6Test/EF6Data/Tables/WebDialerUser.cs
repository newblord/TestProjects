namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebDialerUser")]
    public partial class WebDialerUser
    {
        [Key]
        public int WEB_DIALER_USER_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(128)]
        public string DIALER_USER_ID { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual WebDialerUser WebDialerUser1 { get; set; }

        public virtual WebDialerUser WebDialerUser2 { get; set; }
    }
}
