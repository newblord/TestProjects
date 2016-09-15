namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallTeam()
        {
            WebCallTeamUsers = new HashSet<WebCallTeamUser>();
        }

        [Key]
        public int Web_Call_Team_Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime Create_Date { get; set; }

        [Required]
        [StringLength(3)]
        public string Created_By { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallTeamUser> WebCallTeamUsers { get; set; }
    }
}
