namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerFlashQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CUSTOMER_FLASH_QUESTIONS_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string LOOKUP_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPTION { get; set; }
    }
}
