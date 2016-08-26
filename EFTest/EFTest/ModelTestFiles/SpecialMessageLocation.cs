namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialMessageLocation")]
    public partial class SpecialMessageLocation
    {
        [Key]
        public int SPECIAL_MESSAGE_LOCATION_KEY { get; set; }

        public int? SPECIAL_MESSAGE_KEY { get; set; }

        public short? LOCATION { get; set; }

        public virtual SpecialMessage SpecialMessage { get; set; }
    }
}
