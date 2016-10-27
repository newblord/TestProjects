using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
    public static class Logger
    {
        public static List<string> Warnings { get; private set; }
        public static List<string> Errors { get; private set; }
        public static List<string> Logs { get; private set; }

        public static void AddWarning(string warning)
        {
            if(Warnings == null)
            {
                Warnings = new List<string>();
            }

            Warnings.Add(warning);
        }

        public static void AddError(string error)
        {
            if (Errors == null)
            {
                Errors = new List<string>();
            }

            Errors.Add(error);
        }

        public static void AddLog(string log)
        {
            if(Logs == null)
            {
                Logs = new List<string>();
            }

            Logs.Add(log);
        }
    }
}
