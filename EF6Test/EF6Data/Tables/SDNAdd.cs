namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDNAdd")]
    public partial class SDNAdd
    {
        public int? ENT_NUM { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ADD_NUM { get; set; }

        [StringLength(750)]
        public string ADDRESS { get; set; }

        [StringLength(75)]
        public string CITY { get; set; }

        [StringLength(250)]
        public string COUNTRY { get; set; }

        [StringLength(200)]
        public string ADD_REMARKS { get; set; }

        public virtual SDNMain SDNMain { get; set; }
    }
}
