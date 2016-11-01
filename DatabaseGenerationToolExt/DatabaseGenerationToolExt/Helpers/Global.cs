using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
    public static class Global
    {
        public static DatabaseObjects.DatabaseGenerationSetting Setting { get; private set; }
        public static Microsoft.VisualStudio.Shell.Package Package { get; private set; }

        public static void InitializePackage(Microsoft.VisualStudio.Shell.Package package)
        {
            Package = package;
        }

        public static void InitializeSetting(DatabaseObjects.DatabaseGenerationSetting setting)
        {
            Setting = setting;
        }
    }
}
