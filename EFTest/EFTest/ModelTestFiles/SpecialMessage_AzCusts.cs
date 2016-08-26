namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SpecialMessage_AzCusts
    {
        public double? CUSTOMER_KEY { get; set; }

        [Key]
        public int SPECIAL_MESSAGE_AZ_CUSTS_KEY { get; set; }
    }
}
