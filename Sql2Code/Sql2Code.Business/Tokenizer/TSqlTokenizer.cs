using Sql2Code.Business.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2Code.Business.Tokenizer
{
    public class TSqlTokenizer
    {

        private List<string> Keywords { get; } = new List<string>();

        private List<SqlToken> Tokens = new List<SqlToken>();

        private StringBuilder CurrentTokenValue = new StringBuilder();

        private SqlToken PreviousToken => Tokens.LastOrDefault();

        public TSqlTokenizer()
        {
            GenerateKeyWordList();
        }

        public void TokenizeSql(string sql)
        {
            var lines = sql.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var words = line.Split(' ');

                foreach (var word in words)
                {
                    switch (word.ToUpper())
                    {
                        case "ALTER":
                        case "CREATE":
                            ConsumeValueIntoToken(word.ToUpper(), true);
                            break;
                        case "PROC":
                        case "PROCEDURE":
                        case "FUNCTION":
                            CompleteTokenAndContinue(SqlTokenType.RoutineModification, word.ToUpper());
                            break;
                        case "AS":
                            if(PreviousToken.Type != SqlTokenType.RoutineParameter)
                            {

                            }
                            break;
                        case "BEGIN":
                            if (PreviousToken.Type != SqlTokenType.RoutineParameter)
                            {

                            }
                            break;
                        case "END":
                            break;
                        case "DECLARE":
                            CompleteTokenAndContinue(SqlTokenType.DeclareStatement, word.ToUpper());
                            break;
                        case "SET":
                            if(!line.Contains("SET NOCOUNT"))
                            {

                            }
                            break;
                        default:
                            switch (PreviousToken?.Type)
                            {
                                case SqlTokenType.RoutineModification:
                                    var routineName = word.Split('.').Last().Replace("[", "").Replace("]", "");
                                    CompleteTokenAndContinue(SqlTokenType.RoutineName, routineName);
                                    break;
                                case SqlTokenType.RoutineName:
                                    if(word.StartsWith("@")) // Found Parameter Name
                                    {
                                        ConsumeValueIntoToken(word.Replace("@", ""), false);
                                    }
                                    else
                                    {
                                        var dataType = word;

                                        if(dataType.EndsWith(","))
                                        {
                                            dataType = dataType.Substring(0, dataType.Length - 1);
                                        }

                                        CompleteTokenAndContinue(SqlTokenType.RoutineParameter, $":{dataType.ToUpper()}");
                                    }
                                    break;
                                case SqlTokenType.DeclareStatement:

                                    break;
                                default:
                                    continue;
                            }
                            break;
                    }
                }

            }
        }

        private void ConsumeValueIntoToken(string value, bool insertWhiteSpace)
        {
            CurrentTokenValue.Append(value);

            if (insertWhiteSpace)
            {
                CurrentTokenValue.Append(" ");
            }
        }

        private void CompleteTokenAndContinue(SqlTokenType sqlTokenType, string value)
        {
            ConsumeValueIntoToken(value, false);

            var token = new SqlToken(sqlTokenType, CurrentTokenValue.ToString());

            Tokens.Add(token);

            CurrentTokenValue.Clear();
        }

        private void GenerateKeyWordList()
        {
            Keywords.Add("ALTER");
            Keywords.Add("BEGIN");
            Keywords.Add("BREAK");
            Keywords.Add("BY");
            Keywords.Add("CASE");
            Keywords.Add("CLOSE");
            Keywords.Add("COMMIT");
            Keywords.Add("CONTINUE");
            Keywords.Add("CREATE");
            Keywords.Add("CURSOR");
            Keywords.Add("DEALLOCATE");
            Keywords.Add("DECLARE");
            Keywords.Add("ELSE");
            Keywords.Add("END");
            Keywords.Add("EXEC");
            Keywords.Add("EXECUTE");
            Keywords.Add("EXISTS");
            Keywords.Add("EXIT");
            Keywords.Add("FETCH");
            Keywords.Add("FOR");
            Keywords.Add("FUNCTION");
            Keywords.Add("GOTO");
            Keywords.Add("IF");
            Keywords.Add("LIKE");
            Keywords.Add("NONCLUSTERED");
            Keywords.Add("NOT");
            Keywords.Add("NULL");
            Keywords.Add("NULLIF");
            Keywords.Add("OPEN");
            Keywords.Add("OR");
            Keywords.Add("PRINT");
            Keywords.Add("PROC");
            Keywords.Add("PROCEDURE");
            Keywords.Add("RAISERROR");
            Keywords.Add("RETURN");
            Keywords.Add("ROLLBACK");
            Keywords.Add("SET");
            Keywords.Add("THEN");
            Keywords.Add("TRAN");
            Keywords.Add("TRANSACTION");
            Keywords.Add("TRY_CONVERT");
            Keywords.Add("WHEN");
            Keywords.Add("WHERE");
            Keywords.Add("WHILE");
        }
    }
}
