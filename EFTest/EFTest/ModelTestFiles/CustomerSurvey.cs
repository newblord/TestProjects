namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerSurvey")]
    public partial class CustomerSurvey
    {
        [Key]
        public int CUSTOMER_SURVEY_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public short TRANS_TYPE { get; set; }

        public bool NEW_CUSTOMER { get; set; }

        public byte NEW_PRA { get; set; }

        public byte NEW_TITLE { get; set; }

        public byte NEW_SIG { get; set; }

        public byte NEW_CHECK { get; set; }

        public bool NEW_TYPE { get; set; }

        public int RESPONSE_NUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(10)]
        public string CALLED_NUM { get; set; }

        [Required]
        [StringLength(10)]
        public string CALLED_FROM_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string CALLED_FROM_CITY_STATE { get; set; }

        public byte? QUESTION1 { get; set; }

        public byte? QUESTION2 { get; set; }

        public byte? QUESTION3 { get; set; }

        public byte? QUESTION4 { get; set; }

        public byte? QUESTION5 { get; set; }

        public byte? QUESTION6 { get; set; }

        public byte? QUESTION7 { get; set; }

        public byte? QUESTION8 { get; set; }

        public byte? QUESTION9 { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? QUESTIONAVG { get; set; }
    }
}
