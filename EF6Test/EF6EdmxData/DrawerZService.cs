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
    
    public partial class DrawerZService
    {
        public int DRAWERZ_SERVICE_KEY { get; set; }
        public int DRAWERZ_KEY { get; set; }
        public short LOCATION { get; set; }
        public int SERVICE_DETAIL_KEY { get; set; }
        public int DRAWERZ_QTY { get; set; }
        public int CNTZ_QTY { get; set; }
    
        public virtual DrawerZ DrawerZ { get; set; }
        public virtual ServiceDetail ServiceDetail { get; set; }
    }
}