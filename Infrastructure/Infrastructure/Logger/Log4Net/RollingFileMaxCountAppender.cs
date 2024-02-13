using log4net.Appender;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edovo.Infrastructure.Logger.Log4Net
{
    public class RollingFileMaxCountAppender : RollingFileAppender
    {
        public RollingFileMaxCountAppender()
        : base()
        {
        }

        protected override void SafeOpenFile(string fileName, bool append)
        {
            base.SafeOpenFile(fileName, append);

            if (append == false)
            {
                int maxCountRollBackups = Convert.ToInt32(ConfigurationManager.AppSettings["MaxCountRollBackups"]?.ToString());

                if (maxCountRollBackups == 0)
                    maxCountRollBackups = 30;

                var directoryInfo = new DirectoryInfo(Path.GetDirectoryName(File));
                var files = directoryInfo.GetFiles().Where(x => x.FullName != File);

                if (RollingStyle == RollingMode.Date || RollingStyle == RollingMode.Composite)
                {
                    foreach (var file in files)
                    {
                        if (file.LastWriteTime < DateTime.Today.AddDays(-1 * maxCountRollBackups))
                            DeleteFile(file.Name);
                    }
                }
                else if (RollingStyle == RollingMode.Size || RollingStyle == RollingMode.Once)
                {
                    foreach (var file in files.OrderByDescending(x => x.CreationTime).Skip(maxCountRollBackups))
                    {
                        DeleteFile(file.Name);
                    }
                }
            }
        }
    }
}
