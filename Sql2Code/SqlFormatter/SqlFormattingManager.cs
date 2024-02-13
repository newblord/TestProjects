using SqlFormatter.Interfaces;
using SqlFormatter.ParseStructure;

namespace SqlFormatter
{
    public class SqlFormattingManager : ISqlFormattingManager
    {
        //default to built-in
        public SqlFormattingManager() : this(new Tokenizers.TSqlStandardTokenizer(), new Parsers.TSqlStandardParser(), new Formatters.TSqlStandardFormatter()) { }

        //most common use-case, define only formatter
        public SqlFormattingManager(ISqlTreeFormatter formatter) : this(new Tokenizers.TSqlStandardTokenizer(), new Parsers.TSqlStandardParser(), formatter) { }

        public SqlFormattingManager(ISqlTokenizer tokenizer, ISqlTokenParser parser, ISqlTreeFormatter formatter)
        {
            Tokenizer = tokenizer;
            Parser = parser;
            Formatter = formatter;
        }

        public ISqlTokenizer Tokenizer { get; set; }
        public ISqlTokenParser Parser { get; set; }
        public ISqlTreeFormatter Formatter { get; set; }

        public string Format(string inputSQL)
        {
            bool error = false;
            return Format(inputSQL, ref error);
        }

        public string Format(string inputSQL, ref bool errorEncountered)
        {
            Node sqlTree = Parser.ParseSQL(Tokenizer.TokenizeSQL(inputSQL));
            errorEncountered = (sqlTree.GetAttributeValue(SqlStructureConstants.ANAME_ERRORFOUND) == "1");
            return Formatter.FormatSQLTree(sqlTree);
        }

        public static string DefaultFormat(string inputSQL)
        {
            return new SqlFormattingManager().Format(inputSQL);
        }

        public static string DefaultFormat(string inputSQL, ref bool errorsEncountered)
        {
            return new SqlFormattingManager().Format(inputSQL, ref errorsEncountered);
        }
    }

    public interface ISqlFormattingManager
    {
        string Format(string inputSQL);
    }
}
