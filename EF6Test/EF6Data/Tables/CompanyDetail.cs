namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyDetail")]
    public partial class CompanyDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(100)]
        public string CROSS_STREETS { get; set; }

        [Required]
        [StringLength(1000)]
        public string DIRECTIONS { get; set; }

        [Required]
        [StringLength(500)]
        public string NEWS_FLASH { get; set; }

        [Required]
        [StringLength(12)]
        public string FAX { get; set; }

        [Required]
        [StringLength(100)]
        public string ALTERNATE_HOURS { get; set; }

        [Required]
        [StringLength(300)]
        public string STORE_EMAIL_ADDRESS { get; set; }

        public virtual Company Company { get; set; }
    }
}
