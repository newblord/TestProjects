using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2Code.Business.Interaces
{
    public interface IToken
    {
        SqlTokenType Type { get; set; }
        string Value { get; set; }
    }
}
