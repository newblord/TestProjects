using SqlFormatter.Interfaces;

namespace SqlFormatter
{
    public class Token : IToken
    {
        public Token(SqlTokenType type, string value)
        {
            Type = type;
            Value = value;
        }

        public SqlTokenType Type { get; set; }
        public string Value { get; set; }
    }
}
