namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebCallTeamUser
    {
        [Key]
        public int Web_Call_TeamUser_Key { get; set; }

        public int Web_Call_Team_Key { get; set; }

        [Required]
        [StringLength(10)]
        public string Teller { get; set; }

        public DateTime Create_Date { get; set; }

        [Required]
        [StringLength(3)]
        public string Created_By { get; set; }

        public virtual WebCallTeam WebCallTeam { get; set; }
    }
}
