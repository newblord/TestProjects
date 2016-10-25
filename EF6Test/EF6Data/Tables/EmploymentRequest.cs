namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmploymentRequest")]
    public partial class EmploymentRequest
    {
        [Key]
        [Column(Order = 0)]
        public int EMPLOYMENT_REQUEST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(60)]
        public string EMAIL { get; set; }

        [StringLength(25)]
        public string FIRST_NAME { get; set; }

        [StringLength(25)]
        public string LAST_NAME { get; set; }

        public int? EMPLOYMENT_REGION_ID { get; set; }

        [StringLength(5)]
        public string FILE_EXTENSION { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte[] FILE_CONTENTS { get; set; }

        public bool? SENT_TO_MANAGER { get; set; }
    }
}
