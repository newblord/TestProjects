using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
    public class Enum
    {
        public string Name { get; set; }
        public string TypeName { get; set; }
        public List<EnumEntry> Entries { get; set; }
        public Forms.Models.SpellFunctionData SpellFunctionData { get; set; }

        public Enum()
        {
            Entries = new List<EnumEntry>();
        }
    }
}
