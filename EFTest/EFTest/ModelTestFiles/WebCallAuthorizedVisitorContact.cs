namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallAuthorizedVisitorContact")]
    public partial class WebCallAuthorizedVisitorContact
    {
        [Key]
        public int Web_Call_Authorized_Visitor_Contact_Key { get; set; }

        public int Visitor_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [StringLength(1)]
        public string Relationship { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date_Entered { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
