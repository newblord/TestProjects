using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Certificate
    {
        public int CertificateKey { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Password { get; set; }
        public DateTimeOffset DateEnteredUtc { get; set; }
        public DateTimeOffset DateExpiresUtc { get; set; }
    }
}
