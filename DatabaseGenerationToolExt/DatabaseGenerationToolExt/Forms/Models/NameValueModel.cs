using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Forms.Models
{
    public class NameValueModel
    {
        public NameValueModel()
        {

        }

        public NameValueModel(string name, object value)
        {
            Name = name;
            Value = value.ToString();
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
