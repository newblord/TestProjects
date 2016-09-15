namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallIntraChatMessage")]
    public partial class WebCallIntraChatMessage
    {
        [Key]
        public int Web_Call_IntraChat_Message_Key { get; set; }

        public int Web_Call_IntraChat_Session_Key { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Message { get; set; }

        [Required]
        [StringLength(3)]
        public string From_User_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string To_User_Id { get; set; }

        public DateTime Date_Sent { get; set; }

        public virtual WebCallIntraChatSession WebCallIntraChatSession { get; set; }
    }
}
