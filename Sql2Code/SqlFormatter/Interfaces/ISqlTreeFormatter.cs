using SqlFormatter.ParseStructure;

namespace SqlFormatter.Interfaces
{
    public interface ISqlTreeFormatter
    {
        bool HTMLFormatted { get; }
        string ErrorOutputPrefix { get; set; }
        string FormatSQLTree(Node sqlTree);
    }
}
