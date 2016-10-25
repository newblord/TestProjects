namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallIntraChatSession")]
    public partial class WebCallIntraChatSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallIntraChatSession()
        {
            WebCallIntraChatMessages = new HashSet<WebCallIntraChatMessage>();
        }

        [Key]
        public int Web_Call_IntraChat_Session_Key { get; set; }

        [Required]
        [StringLength(3)]
        public string From_User_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string To_User_Id { get; set; }

        public bool From_User_Logged_In { get; set; }

        public bool To_User_Logged_In { get; set; }

        public DateTime? From_User_LogOut_Date { get; set; }

        public DateTime? To_User_LogOut_Date { get; set; }

        public DateTime Date_Created { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallIntraChatMessage> WebCallIntraChatMessages { get; set; }
    }
}
