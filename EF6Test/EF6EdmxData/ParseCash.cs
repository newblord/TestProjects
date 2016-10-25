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
    
    public partial class ParseCash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParseCash()
        {
            this.TransDetailCashes = new HashSet<TransDetailCash>();
            this.VaultCounts = new HashSet<VaultCount>();
            this.VaultCounts1 = new HashSet<VaultCount>();
        }
    
        public int PARSE_CASH_KEY { get; set; }
        public decimal PC_100 { get; set; }
        public decimal PC_50 { get; set; }
        public decimal PC_20 { get; set; }
        public decimal PC_10 { get; set; }
        public decimal PC_05 { get; set; }
        public decimal PC_01 { get; set; }
        public decimal PC_ROLL_HLF { get; set; }
        public decimal PC_ROLL_QTR { get; set; }
        public decimal PC_ROLL_DIME { get; set; }
        public decimal PC_ROLL_NIC { get; set; }
        public decimal PC_ROLL_PEN { get; set; }
        public decimal PC_LOOSE_HLF { get; set; }
        public decimal PC_LOOSE_QTR { get; set; }
        public decimal PC_LOOSE_DIME { get; set; }
        public decimal PC_LOOSE_NIC { get; set; }
        public decimal PC_LOOSE_PEN { get; set; }
        public decimal PC_MISC { get; set; }
        public decimal PC_ROLL_02 { get; set; }
        public decimal PC_ROLL_01 { get; set; }
        public decimal PC_ROLL_2P { get; set; }
        public decimal PC_ROLL_20P { get; set; }
        public decimal PC_LOOSE_01 { get; set; }
        public decimal PC_LOOSE_02 { get; set; }
        public decimal PC_LOOSE_2P { get; set; }
        public decimal PC_LOOSE_20P { get; set; }
        public Nullable<decimal> PC_TOT_CASH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransDetailCash> TransDetailCashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCount> VaultCounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultCount> VaultCounts1 { get; set; }
    }
}
