using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.Helpers
{
    public static class Logger
    {
        public static StringBuilder Warnings { get; private set; }
        public static StringBuilder Errors { get; private set; }
        public static StringBuilder Logs { get; private set; }

        public static void AddWarning(string warning)
        {
            Warnings.AppendLine(warning);
        }

        public static void AddError(string error)
        {
            Errors.AppendLine(error);
        }

        public static void AddLog(string log)
        {
            Logs.AppendLine(log);
        }

        public static void ResetLogs()
        {
            Warnings = new StringBuilder();
            Errors = new StringBuilder();
            Logs = new StringBuilder();

            Warnings.AppendLine("// Warnings");
            Errors.AppendLine("// Errors");
        }
    }
}
