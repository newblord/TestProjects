namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RIS")]
    public partial class RI
    {
        [Column(TypeName = "smalldatetime")]
        public DateTime DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string TLR { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMOUNT { get; set; }

        [StringLength(500)]
        public string NOTES { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOLLOWUP { get; set; }

        public byte? PTYP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? xtime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ztime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? btime { get; set; }

        [Key]
        public int RIS_Id { get; set; }

        public DateTime? BTIME2 { get; set; }

        public bool prepay { get; set; }

        public int? dos_refno { get; set; }

        public int? reverse_ris_id { get; set; }

        public int Ris_Audit_ID { get; set; }

        public int Ris_Task_ID { get; set; }

        public int risrept_key { get; set; }

        [StringLength(50)]
        public string DOS_MIGRATED_ID { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public short? GL_ACCT { get; set; }

        public virtual RISAUDIT RISAUDIT { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        public virtual RisTask RisTask { get; set; }
    }
}
