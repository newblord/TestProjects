using Sql2Code.Business.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2Code.Business
{
    public class SqlToken : IToken
    {
        public SqlToken(SqlTokenType type, string value)
        {
            Type = type;
            Value = value;
        }

        public SqlTokenType Type { get; set; }
        public string Value { get; set; }
    }
}
