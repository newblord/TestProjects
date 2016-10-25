namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectionAction")]
    public partial class CollectionAction
    {
        [Key]
        public int COLLECTION_ACTION_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(600)]
        public string NOTE { get; set; }

        public int AGENT_ACTION_KEY { get; set; }

        public int AGENT_RESULT_KEY1 { get; set; }

        public int? AGENT_RESULT_KEY2 { get; set; }

        public int? COLLECTION_MOVEMENT_KEY { get; set; }

        public int? TASK_ACTION_RESULT_KEY { get; set; }

        public int? CUSTOMER_PHONE_NUMBER_KEY { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public virtual AgentAction AgentAction { get; set; }

        public virtual Company Company { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
