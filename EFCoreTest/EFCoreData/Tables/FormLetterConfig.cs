using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterConfig
    {
        public int FormLetterConfigKey { get; set; }
        public bool IsAdAstra { get; set; }
        public string FtpUsername { get; set; }
        public string FtpPassword { get; set; }
        public bool EnableUploadBatch { get; set; }
        public bool EnableDownloadBatch { get; set; }
        public bool EnableBatchValidation { get; set; }
    }
}
