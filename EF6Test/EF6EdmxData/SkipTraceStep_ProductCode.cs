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
    
    public partial class SkipTraceStep_ProductCode
    {
        public int SKIP_TRACE_STEP_KEY { get; set; }
        public string PRODUCT_CODE { get; set; }
        public int SKIP_TRACE_STEP_PRODUCT_CODE_KEY { get; set; }
    
        public virtual SkipTraceStep SkipTraceStep { get; set; }
    }
}