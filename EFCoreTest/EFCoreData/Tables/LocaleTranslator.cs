using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LocaleTranslator
    {
        public int LocaleTranslatorKey { get; set; }
        public string CountryCode { get; set; }
        public string EnglishValue { get; set; }
        public string LocaleValue { get; set; }
        public bool ExactMatchOnly { get; set; }
    }
}
