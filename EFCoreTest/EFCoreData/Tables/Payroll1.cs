using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Payroll1
    {
        public string ChkType { get; set; }
        public decimal Price { get; set; }
        public decimal Fee { get; set; }
        public decimal Rate { get; set; }
        public short Location { get; set; }
        public int Payroll1Key { get; set; }
    }
}
