namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHGroup")]
    public partial class ACHGroup
    {
        [Key]
        [Column(Order = 0)]
        public int ACH_GROUP_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string BM_DR_ACH_NUMBER { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string BM_CR_ACH_NUMBER { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string BM_COLL_DR_ACH_NUMBER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string IL_DR_ACH_NUMBER { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string IL_CR_ACH_NUMBER { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string IL_COLL_DR_ACH_NUMBER { get; set; }
    }
}
