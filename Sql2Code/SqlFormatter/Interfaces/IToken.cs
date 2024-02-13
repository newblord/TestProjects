using System;

namespace SqlFormatter.Interfaces
{
    public interface IToken
    {
        SqlTokenType Type { get; set; }
        string Value { get; set; }
    }
}
