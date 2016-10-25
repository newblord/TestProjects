namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfigInstanceGroup")]
    public partial class ProcessConfigInstanceGroup
    {
        [Key]
        public int PROCESS_CONFIG_INSTANCE_GROUP_KEY { get; set; }

        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        public int SECURITYGROUP_KEY { get; set; }

        public virtual ProcessConfigInstance ProcessConfigInstance { get; set; }

        public virtual SecurityGroup SecurityGroup { get; set; }
    }
}
