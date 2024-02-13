using SqlFormatter.ParseStructure;

namespace SqlFormatter.Interfaces
{
    public interface ISqlTokenParser
    {
        Node ParseSQL(ITokenList tokenList);
    }
}
