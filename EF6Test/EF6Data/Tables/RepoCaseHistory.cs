namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RepoCaseHistory")]
    public partial class RepoCaseHistory
    {
        [Key]
        public int REPO_CASE_HISTORY_KEY { get; set; }

        public int COLLECTION_NOTE_KEY { get; set; }

        public int TITLELOAN_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string PREVIOUS_REPO_CASE_NUM { get; set; }

        [Required]
        [StringLength(20)]
        public string UPDATED_REPO_CASE_NUM { get; set; }

        [Required]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime UPDATED_DATE { get; set; }

        public virtual CollectionNote CollectionNote { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        public virtual TitleLoan TitleLoan { get; set; }
    }
}
