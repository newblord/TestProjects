//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class CapsRun
    {
        public int CAPS_RUN_KEY { get; set; }
        public Nullable<System.DateTime> START_TIME { get; set; }
        public Nullable<System.DateTime> FINISH_TIME { get; set; }
        public byte CAPS_RUN_STATUS_KEY { get; set; }
        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }
        public int PREV_CAPS_RUN_KEY { get; set; }
    
        public virtual CapsRunStatu CapsRunStatu { get; set; }
    }
}
