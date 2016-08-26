namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallInvalidPhoneNumber")]
    public partial class WebCallInvalidPhoneNumber
    {
        [Key]
        public int Web_Call_Invalid_Phone_Number_Key { get; set; }

        [StringLength(15)]
        public string Phone_Number { get; set; }

        public DateTime? Invalid_Until { get; set; }

        public DateTime Date_Entered { get; set; }
    }
}
