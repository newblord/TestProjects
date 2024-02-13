using System;
using System.Text;
using System.Collections.Generic;
using SqlFormatter.ParseStructure;
using SqlFormatter.Interfaces;

namespace SqlFormatter.Formatters
{
    /// <summary>
    /// This formatter is intended to output *exactly the same content as initially parsed*, unless the 
    /// "HtmlColoring" option is enabled (then it should look the same in HTML, except for the coloring).
    /// </summary>
    public class TSqlIdentityFormatter : ISqlTokenFormatter, ISqlTreeFormatter
    {
        public TSqlIdentityFormatter() : this(false) { }
        public TSqlIdentityFormatter(bool htmlColoring)
        {
            HTMLColoring = htmlColoring;
            ErrorOutputPrefix = MessagingConstants.FormatErrorDefaultMessage + Environment.NewLine;
        }

        public bool HTMLColoring { get; set; }
        public bool HTMLFormatted { get { return HTMLColoring; } }
        public string ErrorOutputPrefix { get; set; }

        public string FormatSQLTree(Node sqlTreeDoc)
        {
            BaseFormatterState state = new BaseFormatterState(HTMLColoring);

            if (sqlTreeDoc.Name == SqlStructureConstants.SQL_ROOT && sqlTreeDoc.GetAttributeValue(SqlStructureConstants.ANAME_ERRORFOUND) == "1")
                state.AddOutputContent(ErrorOutputPrefix);

            //pass "doc" itself into process: useful/necessary when formatting NOFORMAT sub-regions from standard formatter
            ProcessSqlNodeList(new[] { sqlTreeDoc }, state);
            return state.DumpOutput();
        }

        private static void ProcessSqlNodeList(IEnumerable<Node> rootList, BaseFormatterState state)
        {
            foreach (Node contentElement in rootList)
                ProcessSqlNode(state, contentElement);
        }

        private static void ProcessSqlNode(BaseFormatterState state, Node contentElement)
        {
            if (contentElement.GetAttributeValue(SqlStructureConstants.ANAME_HASERROR) == "1")
                state.OpenClass(SqlHtmlConstants.CLASS_ERRORHIGHLIGHT);

            switch (contentElement.Name)
            {
                case SqlStructureConstants.DDLDETAIL_PARENS:
                case SqlStructureConstants.DDL_PARENS:
				case SqlStructureConstants.FUNCTION_PARENS:
				case SqlStructureConstants.IN_PARENS:
				case SqlStructureConstants.EXPRESSION_PARENS:
                case SqlStructureConstants.SELECTIONTARGET_PARENS:
                    state.AddOutputContent("(");
                    ProcessSqlNodeList(contentElement.Children, state);
                    state.AddOutputContent(")");
                    break;

                case SqlStructureConstants.SQL_ROOT:
                case SqlStructureConstants.SQL_STATEMENT:
                case SqlStructureConstants.SQL_CLAUSE:
                case SqlStructureConstants.BOOLEAN_EXPRESSION:
                case SqlStructureConstants.DDL_PROCEDURAL_BLOCK:
                case SqlStructureConstants.DDL_OTHER_BLOCK:
                case SqlStructureConstants.DDL_DECLARE_BLOCK:
                case SqlStructureConstants.CURSOR_DECLARATION:
                case SqlStructureConstants.BEGIN_END_BLOCK:
                case SqlStructureConstants.TRY_BLOCK:
                case SqlStructureConstants.CATCH_BLOCK:
                case SqlStructureConstants.CASE_STATEMENT:
                case SqlStructureConstants.CASE_INPUT:
                case SqlStructureConstants.CASE_WHEN:
                case SqlStructureConstants.CASE_THEN:
                case SqlStructureConstants.CASE_ELSE:
                case SqlStructureConstants.IF_STATEMENT:
                case SqlStructureConstants.ELSE_CLAUSE:
                case SqlStructureConstants.WHILE_LOOP:
                case SqlStructureConstants.DDL_AS_BLOCK:
                case SqlStructureConstants.BETWEEN_CONDITION:
                case SqlStructureConstants.BETWEEN_LOWERBOUND:
                case SqlStructureConstants.BETWEEN_UPPERBOUND:
                case SqlStructureConstants.CTE_WITH_CLAUSE:
                case SqlStructureConstants.CTE_ALIAS:
                case SqlStructureConstants.CTE_AS_BLOCK:
                case SqlStructureConstants.CURSOR_FOR_BLOCK:
                case SqlStructureConstants.CURSOR_FOR_OPTIONS:
                case SqlStructureConstants.TRIGGER_CONDITION:
                case SqlStructureConstants.COMPOUNDKEYWORD:
                case SqlStructureConstants.BEGIN_TRANSACTION:
                case SqlStructureConstants.ROLLBACK_TRANSACTION:
                case SqlStructureConstants.SAVE_TRANSACTION:
                case SqlStructureConstants.COMMIT_TRANSACTION:
                case SqlStructureConstants.BATCH_SEPARATOR:
                case SqlStructureConstants.SET_OPERATOR_CLAUSE:
                case SqlStructureConstants.CONTAINER_OPEN:
                case SqlStructureConstants.CONTAINER_MULTISTATEMENT:
                case SqlStructureConstants.CONTAINER_SINGLESTATEMENT:
                case SqlStructureConstants.CONTAINER_GENERALCONTENT:
                case SqlStructureConstants.CONTAINER_CLOSE:
                case SqlStructureConstants.SELECTIONTARGET:
                case SqlStructureConstants.PERMISSIONS_BLOCK:
                case SqlStructureConstants.PERMISSIONS_DETAIL:
                case SqlStructureConstants.PERMISSIONS_TARGET:
                case SqlStructureConstants.PERMISSIONS_RECIPIENT:
                case SqlStructureConstants.DDL_WITH_CLAUSE:
                case SqlStructureConstants.MERGE_CLAUSE:
                case SqlStructureConstants.MERGE_TARGET:
                case SqlStructureConstants.MERGE_USING:
                case SqlStructureConstants.MERGE_CONDITION:
                case SqlStructureConstants.MERGE_WHEN:
                case SqlStructureConstants.MERGE_THEN:
                case SqlStructureConstants.MERGE_ACTION:
                case SqlStructureConstants.JOIN_ON_SECTION:
                case SqlStructureConstants.DDL_RETURNS:
                    foreach (Node childNode in contentElement.Children)
                        ProcessSqlNode(state, childNode);
                    break;

                case SqlStructureConstants.COMMENT_MULTILINE:
                    state.AddOutputContent("/*" + contentElement.TextValue + "*/", SqlHtmlConstants.CLASS_COMMENT);
                    break;
                case SqlStructureConstants.COMMENT_SINGLELINE:
                    state.AddOutputContent("--" + contentElement.TextValue, SqlHtmlConstants.CLASS_COMMENT);
                    break;
                case SqlStructureConstants.COMMENT_SINGLELINE_CSTYLE:
                    state.AddOutputContent("//" + contentElement.TextValue, SqlHtmlConstants.CLASS_COMMENT);
                    break;
                case SqlStructureConstants.STRING:
                    state.AddOutputContent("'" + contentElement.TextValue.Replace("'", "''") + "'", SqlHtmlConstants.CLASS_STRING);
                    break;
                case SqlStructureConstants.NSTRING:
                    state.AddOutputContent("N'" + contentElement.TextValue.Replace("'", "''") + "'", SqlHtmlConstants.CLASS_STRING);
                    break;
                case SqlStructureConstants.QUOTED_STRING:
                    state.AddOutputContent("\"" + contentElement.TextValue.Replace("\"", "\"\"") + "\"");
                    break;
                case SqlStructureConstants.BRACKET_QUOTED_NAME:
                    state.AddOutputContent("[" + contentElement.TextValue.Replace("]", "]]") + "]");
                    break;

                case SqlStructureConstants.COMMA:
                case SqlStructureConstants.PERIOD:
                case SqlStructureConstants.SEMICOLON:
                case SqlStructureConstants.ASTERISK:
                case SqlStructureConstants.EQUALSSIGN:
                case SqlStructureConstants.SCOPERESOLUTIONOPERATOR:
                case SqlStructureConstants.ALPHAOPERATOR:
                case SqlStructureConstants.OTHEROPERATOR:
                    state.AddOutputContent(contentElement.TextValue, SqlHtmlConstants.CLASS_OPERATOR);
                    break;

                case SqlStructureConstants.AND_OPERATOR:
                case SqlStructureConstants.OR_OPERATOR:
                    state.AddOutputContent(contentElement.ChildByName(SqlStructureConstants.OTHERKEYWORD).TextValue, SqlHtmlConstants.CLASS_OPERATOR);
                    break;

                case SqlStructureConstants.FUNCTION_KEYWORD:
                    state.AddOutputContent(contentElement.TextValue, SqlHtmlConstants.CLASS_FUNCTION);
                    break;

                case SqlStructureConstants.OTHERKEYWORD:
                case SqlStructureConstants.DATATYPE_KEYWORD:
                case SqlStructureConstants.PSEUDONAME:
                    state.AddOutputContent(contentElement.TextValue, SqlHtmlConstants.CLASS_KEYWORD);
                    break;

                case SqlStructureConstants.OTHERNODE:
                case SqlStructureConstants.WHITESPACE:
                case SqlStructureConstants.NUMBER_VALUE:
                case SqlStructureConstants.MONETARY_VALUE:
                case SqlStructureConstants.BINARY_VALUE:
                case SqlStructureConstants.LABEL:
                    state.AddOutputContent(contentElement.TextValue);
                    break;
                default:
                    throw new Exception("Unrecognized element in SQL Xml!");
            }

            if (contentElement.GetAttributeValue(SqlStructureConstants.ANAME_HASERROR) == "1")
                state.CloseClass();
        }


        public string FormatSQLTokens(ITokenList sqlTokenList)
        {
            StringBuilder outString = new StringBuilder();

            if (sqlTokenList.HasUnfinishedToken)
                outString.Append(ErrorOutputPrefix);

            foreach (var entry in sqlTokenList)
            {
                switch (entry.Type)
                {
                    case SqlTokenType.MultiLineComment:
                        outString.Append("/*");
                        outString.Append(entry.Value);
                        outString.Append("*/");
                        break;
                    case SqlTokenType.SingleLineComment:
                        outString.Append("--");
                        outString.Append(entry.Value);
                        break;
                    case SqlTokenType.SingleLineCommentCStyle:
                        outString.Append("//");
                        outString.Append(entry.Value);
                        break;
                    case SqlTokenType.String:
                        outString.Append("'");
                        outString.Append(entry.Value.Replace("'", "''"));
                        outString.Append("'");
                        break;
                    case SqlTokenType.NationalString:
                        outString.Append("N'");
                        outString.Append(entry.Value.Replace("'", "''"));
                        outString.Append("'");
                        break;
                    case SqlTokenType.QuotedString:
                        outString.Append("\"");
                        outString.Append(entry.Value.Replace("\"", "\"\""));
                        outString.Append("\"");
                        break;
                    case SqlTokenType.BracketQuotedName:
                        outString.Append("[");
                        outString.Append(entry.Value.Replace("]", "]]"));
                        outString.Append("]");
                        break;

                    case SqlTokenType.OpenParens:
                    case SqlTokenType.CloseParens:
                    case SqlTokenType.Comma:
                    case SqlTokenType.Period:
                    case SqlTokenType.Semicolon:
                    case SqlTokenType.Colon:
                    case SqlTokenType.Asterisk:
                    case SqlTokenType.EqualsSign:
                    case SqlTokenType.OtherNode:
                    case SqlTokenType.WhiteSpace:
                    case SqlTokenType.OtherOperator:
                    case SqlTokenType.Number:
                    case SqlTokenType.BinaryValue:
                    case SqlTokenType.MonetaryValue:
                    case SqlTokenType.PseudoName:
                        outString.Append(entry.Value);
                        break;
                    default:
                        throw new Exception("Unrecognized Token Type in Token List!");
                }
            }

            return outString.ToString();
        }
    }
}
