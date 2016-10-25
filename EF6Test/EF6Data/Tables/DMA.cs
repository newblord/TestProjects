namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMA")]
    public partial class DMA
    {
        [Column("DMA")]
        public int? DMA1 { get; set; }

        [StringLength(5)]
        public string Zip_Code { get; set; }

        [StringLength(150)]
        public string DMA_Name { get; set; }

        [StringLength(50)]
        public string Additional_DMA { get; set; }

        public int? State_Code { get; set; }

        public int? City_Code { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(150)]
        public string City { get; set; }

        public int? City_Size { get; set; }

        public int? NMR_Terr { get; set; }

        public int? DMA_Rank { get; set; }

        [StringLength(50)]
        public string Metro_Indicator { get; set; }

        [Key]
        public int DMA_KEY { get; set; }

        [StringLength(30)]
        public string City_Name { get; set; }
    }
}
