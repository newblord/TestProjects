using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LocaleSetting
    {
        public int LocaleSettingKey { get; set; }
        public string CurrencySymbol { get; set; }
        public string PhoneFormat { get; set; }
        public string ZipFormat { get; set; }
        public string AddressFormat { get; set; }
        public byte DebitCardMaxLen { get; set; }
        public string SsnOrNin { get; set; }
        public bool ShowItem { get; set; }
        public bool EnableVerifyBank { get; set; }
        public bool EnableKbb { get; set; }
        public bool EnableIat { get; set; }
        public bool EnableHpi { get; set; }
    }
}
