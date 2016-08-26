namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IpToCountry")]
    public partial class IpToCountry
    {
        public long FromIP { get; set; }

        public long ToIP { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [Key]
        public long IPTOCOUNTRY_KEY { get; set; }
    }
}
