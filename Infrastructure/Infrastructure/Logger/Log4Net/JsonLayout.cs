using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web;

namespace Edovo.Infrastructure.Logger.Log4Net
{
    public class JsonLayout : LayoutSkeleton
    {
        static readonly string ProcessSessionId = Guid.NewGuid().ToString();
        static readonly int ProcessId = Process.GetCurrentProcess().Id;
        static readonly string MachineName = Environment.MachineName;

        public JsonLayout()
        {
            this.IgnoresException = false;
        }

        public override void ActivateOptions()
        {
            
        }

        public override void Format(TextWriter writer, LoggingEvent e)
        {
            var dic = new Dictionary<string, object>
            {
                ["processSessionId"] = ProcessSessionId,
                ["level"] = e.Level.DisplayName,
                ["messageObject"] = e.MessageObject,
                ["renderedMessage"] = e.RenderedMessage,
                ["time"] = e.TimeStamp.ToUniversalTime().ToString("O"),
                ["logger"] = e.LoggerName,
                //["thread"] = e.ThreadName,
                ["exceptionObject"] = e.ExceptionObject,
                ["exceptionObjectString"] = e.ExceptionObject == null ? null : e.GetExceptionString(),
                ["userName"] = e.UserName,
                //["domain"] = e.Domain,
                //["ipaddress"] = HttpContext.Current?.Request?.ServerVariables["remote_addr"],
                //["identity"] = e.Identity,
                ["location"] = e.LocationInformation.FullInfo
                //["pid"] = ProcessId,
                //["machineName"] = MachineName,
                //["workingSet"] = Environment.WorkingSet,
                //["osVersion"] = Environment.OSVersion.ToString(),
                //["is64bitOS"] = Environment.Is64BitOperatingSystem,
                //["is64bitProcess"] = Environment.Is64BitProcess,
                //["properties"] = e.GetProperties()
            };

            writer.WriteLine(JsonConvert.SerializeObject(dic));
        }
    }
}
