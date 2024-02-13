using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

#if NETFRAMEWORK
using System.Web;
#endif


namespace Edovo.Infrastructure.Logger.Log4Net
{
    public class Log4NetLogger
    {

        public ILog Logger { get; private set; }

        public Hierarchy Hierarchy => (Hierarchy)Repository;

        public readonly ILoggerRepository Repository;

        public Log4NetLogger(Type type)
        {
            Repository = LogManager.GetRepository(Assembly.GetEntryAssembly());

            log4net.Config.XmlConfigurator.Configure(Repository);

            Logger = LogManager.GetLogger(type);

            if(!Hierarchy.Configured)
            {
                ConfigureLogger();
            }
        }

        private void ConfigureLogger()
        {
            var jsonLayout = new JsonLayout();
            jsonLayout.ActivateOptions();

            string appName = Assembly.GetExecutingAssembly().GetName().Name;

            RollingFileMaxCountAppender roller = new RollingFileMaxCountAppender
            {
                AppendToFile = true,
                File = $@"C:\Logs\{appName}\{appName}",
                Layout = jsonLayout,
                MaxSizeRollBackups = 5,
                MaximumFileSize = "1GB",
                RollingStyle = RollingFileAppender.RollingMode.Date,
                StaticLogFileName = false,
                DatePattern = "_yyyyMMdd'.log'"
            };

            roller.ActivateOptions();
            Hierarchy.Root.AddAppender(roller);

            Hierarchy.Root.Level = Level.All;
            Hierarchy.Configured = true;
        }
        
        private IAppender GetJsonLayout()
        {
            var appenders = Hierarchy
                                .Root
                                .Appenders
                                .ToArray();

            return appenders.Where(x => ((dynamic)Convert.ChangeType(x, x.GetType())).Layout.GetType() == typeof(JsonLayout)).FirstOrDefault();
        }

        private void PrepareValues(Dictionary<string, object> values, Level level)
        {
            var time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:mmm tt GMT zzz");

            var jsonLayout = GetJsonLayout();

            if (jsonLayout == null)
            {
                values.Add("level", level.DisplayName);
                values.Add("time", time);
            }
        }

        public void LogInfo(object data)
        {
            LogInfo(new Dictionary<string, object>() { { "data", data } });
        }

        public void LogInfo(string message)
        {
            LogInfo(new Dictionary<string, object>() { { "message", message } });
        }

        public void LogInfo(Dictionary<string, object> values)
        {
            PrepareValues(values, Level.Info);

            Logger.Info(values);
        }

        public void LogWarning(object data)
        {
            LogWarning(new Dictionary<string, object>() { { "data", data } });
        }

        public void LogWarning(string message)
        {
            LogWarning(new Dictionary<string, object>() { { "message", message } });
        }

        public void LogWarning(Dictionary<string, object> values)
        {
            PrepareValues(values, Level.Warn);

            Logger.Warn(values);
        }

        public void LogError(string message)
        {
            LogError(message, null);
        }

        public void LogError(string message, Exception ex)
        {
            LogError(new Dictionary<string, object>() { { "message", message } }, ex);
        }

        public void LogError(Dictionary<string, object> values, Exception ex)
        {
            PrepareValues(values, Level.Error);

            Logger.Error(values, ex);
        }

    }
}
