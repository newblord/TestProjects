namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebRemoteControl")]
    public partial class WebRemoteControl
    {
        [Key]
        public int WEB_REMOTE_CONTROL_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(60)]
        public string TELLER_EMAIL { get; set; }

        [Required]
        [StringLength(36)]
        public string SESSION_GUID { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(512)]
        public string CUSTOMER_URL { get; set; }

        public DateTime? DATE_ENDED { get; set; }

        [StringLength(25)]
        public string First_Name { get; set; }

        [StringLength(25)]
        public string Last_Name { get; set; }

        [StringLength(25)]
        public string GoToAssist_Session_ID { get; set; }
    }
}
