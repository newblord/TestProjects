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
    
    public partial class usp_WebCallQueueLoad_OnlineItems_Result
    {
        public int WEB_CALL_QUEUE_KEY { get; set; }
        public string CATEGORY { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string PAGE { get; set; }
        public string Status { get; set; }
        public string Chat { get; set; }
        public string ChatTopic { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string HOME_PHONE { get; set; }
        public string CELL_PHONE { get; set; }
        public string WORK_PHONE { get; set; }
        public int HistoryItemCount { get; set; }
        public string WebSource { get; set; }
        public System.Guid WEB_CALL_CHAT_SESSION_KEY { get; set; }
        public string WEB_CALL_CHAT_CSR_KEY { get; set; }
        public Nullable<long> WEB_VISIT_KEY { get; set; }
        public Nullable<int> WEB_CALL_CUSTOMER_KEY { get; set; }
        public Nullable<int> WEB_CALL_LOAN_APP_KEY { get; set; }
        public Nullable<int> WEB_CALL_VISITOR_KEY { get; set; }
        public Nullable<int> WEB_CALL_RARR_KEY { get; set; }
        public Nullable<System.DateTime> DATE_REQUESTED { get; set; }
        public Nullable<System.DateTime> DATE_ACCEPTED { get; set; }
        public string WEB_STATUS { get; set; }
        public short Location { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string LeadId { get; set; }
        public string Buyer { get; set; }
        public decimal SoldAmount { get; set; }
        public string FinalScore { get; set; }
        public int WORK_ITEM_COLOR { get; set; }
        public Nullable<bool> IS_ONLINE { get; set; }
    }
}