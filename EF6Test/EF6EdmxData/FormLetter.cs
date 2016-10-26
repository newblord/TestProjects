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
    
    public partial class FormLetter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormLetter()
        {
            this.FormLetterOnDemands = new HashSet<FormLetterOnDemand>();
            this.FormLetterPrinteds = new HashSet<FormLetterPrinted>();
            this.FormLetterProducts = new HashSet<FormLetterProduct>();
            this.FormLetter1 = new HashSet<FormLetter>();
            this.FormLetters = new HashSet<FormLetter>();
            this.RISAUDITs = new HashSet<RISAUDIT>();
            this.Companies = new HashSet<Company>();
            this.FormLetter11 = new HashSet<FormLetter>();
            this.FormLetters1 = new HashSet<FormLetter>();
        }
    
        public int FORM_LETTER_KEY { get; set; }
        public string FORM_LETTER_NAME { get; set; }
        public string FORM_LETTER_DESCRIPTION { get; set; }
        public string FORM_LETTER_BODY { get; set; }
        public string LANGUAGE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_AD_ASTRA { get; set; }
        public bool IS_INITIAL_LETTER { get; set; }
        public bool IS_AD_ASTRA_ACH_LETTER { get; set; }
        public short AFTER_DAYS { get; set; }
        public bool IS_AFTER_CREDIT_REPORT { get; set; }
        public System.DateTime PRINT_AFTER_COLL_DATE { get; set; }
        public decimal MINIMUM_BALANCE { get; set; }
        public Nullable<int> SET_AUDIT_CODE_KEY { get; set; }
        public string ON_DEMAND_PROMPT_1 { get; set; }
        public string ON_DEMAND_PROMPT_2 { get; set; }
        public string ON_DEMAND_PROMPT_3 { get; set; }
        public string ON_DEMAND_PROMPT_4 { get; set; }
        public string ON_DEMAND_PROMPT_5 { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public System.DateTime DATE_UPDATED { get; set; }
        public string UPDATED_BY { get; set; }
        public int MINIMUM_RI_AGE { get; set; }
        public int MAXIMUM_RI_AGE { get; set; }
        public byte ADD_DAYS_TO_FOLLOWUP_DATE { get; set; }
        public string DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public bool USE_LAST_KNOWN_ADDRESS { get; set; }
        public bool IS_LOAN_MATURED { get; set; }
        public bool IS_LOAN_INACTIVE { get; set; }
        public string RISK_ASSESSMENT { get; set; }
        public int MINIMUM_AA_AGE { get; set; }
        public int MAXIMUM_AA_AGE { get; set; }
        public bool IS_LOAN_NOT_MATURED { get; set; }
        public bool IS_LOAN_NOT_INACTIVE { get; set; }
        public bool IS_LOAN_MATURED_OR_INACTIVE { get; set; }
        public bool IS_LOAN_NOT_MATURED_OR_NOT_INACTIVE { get; set; }
        public bool INCLUDE_PAYMENTS { get; set; }
        public byte LETTER_ORDER { get; set; }
        public bool KEEP_ADDRESS_WHEN_MAIL_RETURNED { get; set; }
        public decimal MINIMUM_RI_AMOUNT { get; set; }
        public decimal MAXIMUM_RI_AMOUNT { get; set; }
        public bool SET_TO_PREV_AUDIT_ID { get; set; }
        public bool EXCLUDE_SECOND_LIEN_LOANS { get; set; }
        public bool IS_ACTIVE { get; set; }
        public short MINIMUM_CYCLES_PAST_DUE { get; set; }
        public short MAXIMUM_CYCLES_PAST_DUE { get; set; }
        public bool IS_UK_ARREARS_NOTICE { get; set; }
        public bool USE_ADASTRA_SDS_UPLOAD_PATH { get; set; }
        public bool INCLUDE_LOAN_HISTORY { get; set; }
    
        public virtual RISAUDIT RISAUDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterPrinted> FormLetterPrinteds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetterProduct> FormLetterProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetter1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RISAUDIT> RISAUDITs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetter11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormLetter> FormLetters1 { get; set; }
    }
}