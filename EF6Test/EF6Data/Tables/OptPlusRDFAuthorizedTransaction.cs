namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptPlusRDFAuthorizedTransaction
    {
        [StringLength(15)]
        public string UNIQUE_PROGRAM_ID { get; set; }

        [StringLength(30)]
        public string GALILEO_ACCOUNT_ID { get; set; }

        [StringLength(30)]
        public string CARD_ID { get; set; }

        [StringLength(17)]
        public string TRANSACTION_DATE { get; set; }

        [StringLength(3)]
        public string TRANSACTION_CURRENCY_CODE { get; set; }

        [StringLength(1)]
        public string ADDRESS_VERIFICATION_RESPONSE { get; set; }

        [StringLength(2)]
        public string AUTHORIZATION_RESPONSE { get; set; }

        [StringLength(13)]
        public string AUTHORIZATION_AMOUNT { get; set; }

        [StringLength(1)]
        public string AUTHORIZATION_AMOUNT_SIGN { get; set; }

        [StringLength(10)]
        public string AUTHORIZATION_CODE { get; set; }

        [StringLength(1)]
        public string NETWORK_CODE { get; set; }

        [StringLength(30)]
        public string MERCHANT_NUMBER { get; set; }

        [StringLength(50)]
        public string MERCHANT_NAME { get; set; }

        [StringLength(4)]
        public string MERCHANT_CATEGORY_CODE { get; set; }

        [StringLength(15)]
        public string TRANSACTION_CODE { get; set; }

        [StringLength(5)]
        public string MERCHANT_COUNTRY_CODE { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [Key]
        public int AUTHORIZED_TRANSACTIONS_KEY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
