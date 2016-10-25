namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xcm")]
    public partial class Xcm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cmkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rrkey { get; set; }

        public int? rakey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COLLECTION_MOVEMENT_KEY { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RISREPT_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AUDIT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOLLOWUP_DATE { get; set; }

        public int? COLLECTION_AGENCY_KEY { get; set; }

        public byte? ASSIGNMENT_NUMBER { get; set; }

        [StringLength(3)]
        public string CR_TELLER { get; set; }

        public int? REASON_FOR_ARREARS_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string ra { get; set; }

        [StringLength(2)]
        public string AUDIT { get; set; }

        [StringLength(50)]
        public string DESC { get; set; }

        [StringLength(10)]
        public string SHORT { get; set; }

        public int? RIS_Audit_Id { get; set; }

        public bool? Displayed { get; set; }

        public bool? IS_AD_ASTRA { get; set; }

        public bool? IS_IN_LEGAL_STATUS { get; set; }

        public int? RIS_AUDIT_KEY { get; set; }

        public bool? DIALER_EXCLUDE { get; set; }

        public bool? SUSPEND_INTEREST { get; set; }

        public bool? REPOSSESSION { get; set; }

        public bool? BLOCK_EMAILS { get; set; }

        public bool? IS_ELIGIBLE_FOR_REPO { get; set; }

        public bool? BLOCK_STATEMENTS { get; set; }

        public bool? IS_PTP { get; set; }
    }
}
