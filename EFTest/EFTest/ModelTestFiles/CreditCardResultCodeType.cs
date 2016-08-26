namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCardResultCodeType")]
    public partial class CreditCardResultCodeType
    {
        [Key]
        public byte RESULT_CODE_TYPE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string RESULT_CODE_TYPE_DESCRIPTION { get; set; }
    }
}
