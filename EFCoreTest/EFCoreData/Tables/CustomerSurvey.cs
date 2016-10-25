using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerSurvey
    {
        public int CustomerSurveyKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public short TransType { get; set; }
        public bool NewCustomer { get; set; }
        public byte NewPra { get; set; }
        public byte NewTitle { get; set; }
        public byte NewSig { get; set; }
        public byte NewCheck { get; set; }
        public bool NewType { get; set; }
        public int ResponseNum { get; set; }
        public DateTime DateEntered { get; set; }
        public string CalledNum { get; set; }
        public string CalledFromNum { get; set; }
        public string CalledFromCityState { get; set; }
        public byte? Question1 { get; set; }
        public byte? Question2 { get; set; }
        public byte? Question3 { get; set; }
        public byte? Question4 { get; set; }
        public byte? Question5 { get; set; }
        public byte? Question6 { get; set; }
        public byte? Question7 { get; set; }
        public byte? Question8 { get; set; }
        public byte? Question9 { get; set; }
        public decimal? Questionavg { get; set; }
    }
}
