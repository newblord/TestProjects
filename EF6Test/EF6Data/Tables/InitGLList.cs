namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InitGLList")]
    public partial class InitGLList
    {
        [Key]
        public int INIT_GL_LIST_KEY { get; set; }

        public short TRANS_CODE { get; set; }

        public short LOCATION { get; set; }

        public int GL_ACCT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }
    }
}
