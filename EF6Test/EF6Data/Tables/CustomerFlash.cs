namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerFlash")]
    public partial class CustomerFlash
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPECIAL_MESSAGE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_EXPIRED { get; set; }
    }
}
