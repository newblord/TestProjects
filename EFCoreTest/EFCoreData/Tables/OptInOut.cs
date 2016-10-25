using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptInOut
    {
        public OptInOut()
        {
            OptInOutEdit = new HashSet<OptInOutEdit>();
        }

        public int OptinoutKey { get; set; }
        public int VisitorKey { get; set; }
        public bool OptoutTransactionCommunication { get; set; }
        public bool OptoutThirdPartyShare { get; set; }
        public bool OptoutEmail { get; set; }
        public bool OptoutSms { get; set; }
        public bool OptoutVoiceblast { get; set; }
        public bool OptoutCallCampaign { get; set; }
        public bool OptoutDirectMail { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public bool OptoutCrSms { get; set; }
        public bool OptoutOptplusSms { get; set; }
        public bool OptoutOptplusVoiceblast { get; set; }
        public bool OptoutOptplusCallCampaign { get; set; }
        public bool OptoutOptplusEmail { get; set; }
        public bool OptoutOptplusDirectMail { get; set; }
        public string SmsPhone { get; set; }
        public string VoiceblastPhone { get; set; }
        public string CallCampaignPhone { get; set; }
        public string OptplusSmsPhone { get; set; }
        public string OptplusVoiceblastPhone { get; set; }
        public string OptplusCallCampaignPhone { get; set; }
        public bool OptoutPrivacyConsent { get; set; }

        public virtual ICollection<OptInOutEdit> OptInOutEdit { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
