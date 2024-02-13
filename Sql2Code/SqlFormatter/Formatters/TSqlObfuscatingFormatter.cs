using System;
using System.Collections.Generic;
using SqlFormatter.Interfaces;
using SqlFormatter.ParseStructure;

namespace SqlFormatter.Formatters
{
    public class TSqlObfuscatingFormatter : ISqlTreeFormatter
    {
        public TSqlObfuscatingFormatter() : this(false, false, false, false, false) { }

        public TSqlObfuscatingFormatter(bool randomizeCase, bool randomizeColor, bool randomizeLineLength, bool preserveComments, bool subtituteKeywords)
        {
            RandomizeCase = randomizeCase;
            RandomizeColor = randomizeColor;
            RandomizeLineLength = randomizeLineLength;
            PreserveComments = preserveComments;
            if (subtituteKeywords)
                KeywordMapping = ObfuscatingKeywordMapping.Instance;

            ErrorOutputPrefix = MessagingConstants.FormatErrorDefaultMessage + Environment.NewLine;

            if (RandomizeCase)
            {
                _currentCaseLimit = _randomizer.Next(MIN_CASE_WORD_LENGTH, MAX_CASE_WORD_LENGTH);
                _currentlyUppercase = _randomizer.Next(0, 2) == 0;
            }
        }

        public bool RandomizeCase { get; set; }
        public bool RandomizeColor { get; set; }
        public bool RandomizeLineLength { get; set; }
        public bool PreserveComments { get; set; }

        public bool HTMLFormatted { get { return RandomizeColor; } }

        public IDictionary<string, string> KeywordMapping = new Dictionary<string, string>();

        public string ErrorOutputPrefix { get; set; }

        private const int MIN_CASE_WORD_LENGTH = 2;
        private const int MAX_CASE_WORD_LENGTH = 8;
        private Random _randomizer = new Random();
        private int _currentCaseLength = 0;
        private int _currentCaseLimit = MAX_CASE_WORD_LENGTH;
        private bool _currentlyUppercase = false;

        public string FormatSQLTree(Node sqlTreeDoc)
        {
            //thread-safe - each call to FormatSQLTree() gets its own independent state object
            TSqlObfuscatingFormattingState state = new TSqlObfuscatingFormattingState(RandomizeColor, RandomizeLineLength);

            if (sqlTreeDoc.Name == SqlStructureConstants.SQL_ROOT && sqlTreeDoc.GetAttributeValue(SqlStructureConstants.ANAME_ERRORFOUND) == "1")
                state.AddOutputContent(ErrorOutputPrefix);

            //pass "doc" itself into process: useful/necessary when formatting MINIFY sub-regions from standard formatter
            ProcessSqlNodeList(new[] { sqlTreeDoc }, state);
            state.BreakIfExpected();
            return state.DumpOutput();
        }

        private void ProcessSqlNodeList(IEnumerable<Node> rootList, TSqlObfuscatingFormattingState state)
        {
            foreach (Node contentElement in rootList)
                ProcessSqlNode(contentElement, state);
        }

        private void ProcessSqlNode(Node contentElement, TSqlObfuscatingFormattingState state)
        {
            switch (contentElement.Name)
            {
                case SqlStructureConstants.SQL_ROOT:
                case SqlStructureConstants.SQL_STATEMENT:
                case SqlStructureConstants.SQL_CLAUSE:
                case SqlStructureConstants.SET_OPERATOR_CLAUSE:
                case SqlStructureConstants.DDL_PROCEDURAL_BLOCK:
                case SqlStructureConstants.DDL_OTHER_BLOCK:
                case SqlStructureConstants.DDL_DECLARE_BLOCK:
                case SqlStructureConstants.CURSOR_DECLARATION:
                case SqlStructureConstants.BEGIN_TRANSACTION:
                case SqlStructureConstants.SAVE_TRANSACTION:
                case SqlStructureConstants.COMMIT_TRANSACTION:
                case SqlStructureConstants.ROLLBACK_TRANSACTION:
                case SqlStructureConstants.CONTAINER_OPEN:
                case SqlStructureConstants.CONTAINER_CLOSE:
                case SqlStructureConstants.WHILE_LOOP:
                case SqlStructureConstants.IF_STATEMENT:
                case SqlStructureConstants.SELECTIONTARGET:
                case SqlStructureConstants.CONTAINER_GENERALCONTENT:
                case SqlStructureConstants.CTE_WITH_CLAUSE:
                case SqlStructureConstants.PERMISSIONS_BLOCK:
                case SqlStructureConstants.PERMISSIONS_DETAIL:
                case SqlStructureConstants.MERGE_CLAUSE:
                case SqlStructureConstants.MERGE_TARGET:
                case SqlStructureConstants.CASE_INPUT:
                case SqlStructureConstants.BOOLEAN_EXPRESSION:
                case SqlStructureConstants.BETWEEN_LOWERBOUND:
                case SqlStructureConstants.BETWEEN_UPPERBOUND:
                case SqlStructureConstants.CONTAINER_SINGLESTATEMENT:
                case SqlStructureConstants.CONTAINER_MULTISTATEMENT:
                case SqlStructureConstants.MERGE_ACTION:
                case SqlStructureConstants.PERMISSIONS_TARGET:
                case SqlStructureConstants.PERMISSIONS_RECIPIENT:
                case SqlStructureConstants.DDL_WITH_CLAUSE:
                case SqlStructureConstants.MERGE_CONDITION:
                case SqlStructureConstants.MERGE_THEN:
                case SqlStructureConstants.JOIN_ON_SECTION:
                case SqlStructureConstants.CTE_ALIAS:
                case SqlStructureConstants.ELSE_CLAUSE:
                case SqlStructureConstants.DDL_AS_BLOCK:
                case SqlStructureConstants.CURSOR_FOR_BLOCK:
                case SqlStructureConstants.TRIGGER_CONDITION:
                case SqlStructureConstants.CURSOR_FOR_OPTIONS:
                case SqlStructureConstants.CTE_AS_BLOCK:
                case SqlStructureConstants.DDL_RETURNS:
                case SqlStructureConstants.MERGE_USING:
                case SqlStructureConstants.MERGE_WHEN:
                case SqlStructureConstants.BETWEEN_CONDITION:
                case SqlStructureConstants.BEGIN_END_BLOCK:
                case SqlStructureConstants.TRY_BLOCK:
                case SqlStructureConstants.CATCH_BLOCK:
                case SqlStructureConstants.CASE_STATEMENT:
                case SqlStructureConstants.CASE_WHEN:
                case SqlStructureConstants.CASE_THEN:
                case SqlStructureConstants.CASE_ELSE:
                case SqlStructureConstants.AND_OPERATOR:
                case SqlStructureConstants.OR_OPERATOR:
                    //these are all containers, and therefore have no impact on obfuscated output.
                    ProcessSqlNodeList(contentElement.Children, state);
                    break;

                case SqlStructureConstants.DDLDETAIL_PARENS:
				case SqlStructureConstants.FUNCTION_PARENS:
				case SqlStructureConstants.IN_PARENS:
				case SqlStructureConstants.DDL_PARENS:
                case SqlStructureConstants.EXPRESSION_PARENS:
                case SqlStructureConstants.SELECTIONTARGET_PARENS:
                    state.SpaceExpected = false;
                    state.AddOutputContent("(");
                    ProcessSqlNodeList(contentElement.Children, state);
                    state.SpaceExpected = false;
                    state.SpaceExpectedForAnsiString = false;
                    state.AddOutputContent(")");
                    break;

                case SqlStructureConstants.WHITESPACE:
                    //do nothing
                    break;

                case SqlStructureConstants.COMMENT_MULTILINE:
                    if (PreserveComments)
                    {
                        state.SpaceExpected = false;
                        state.AddOutputContent("/*" + contentElement.TextValue + "*/");
                    }
                    break;
                case SqlStructureConstants.COMMENT_SINGLELINE:
                    if (PreserveComments)
                    {
                        state.SpaceExpected = false;
                        state.AddOutputContent("--" + contentElement.TextValue.Replace("\r", "").Replace("\n", ""));
                        state.BreakExpected = true;
                    }
                    break;

                case SqlStructureConstants.COMMENT_SINGLELINE_CSTYLE:
                    if (PreserveComments)
                    {
                        state.SpaceExpected = false;
                        state.AddOutputContent("//" + contentElement.TextValue.Replace("\r", "").Replace("\n", ""));
                        state.BreakExpected = true;
                    }
                    break;

                case SqlStructureConstants.BATCH_SEPARATOR:
                    //newline regardless of whether previous element recommended a break or not.
                    state.BreakExpected = true;
                    ProcessSqlNodeList(contentElement.Children, state);
                    state.BreakExpected = true;
                    break;

                case SqlStructureConstants.STRING:
                    state.SpaceIfExpectedForAnsiString();
                    state.SpaceExpected = false;
                    state.AddOutputContent("'" + contentElement.TextValue.Replace("'", "''") + "'");
                    state.SpaceExpectedForAnsiString = true;
                    break;

                case SqlStructureConstants.NSTRING:
                    state.AddOutputContent("N'" + contentElement.TextValue.Replace("'", "''") + "'");
                    state.SpaceExpectedForAnsiString = true;
                    break;

                case SqlStructureConstants.BRACKET_QUOTED_NAME:
                    state.SpaceExpected = false;
                    state.AddOutputContent("[" + contentElement.TextValue.Replace("]", "]]") + "]");
                    break;

                case SqlStructureConstants.QUOTED_STRING:
                    state.SpaceExpected = false;
                    state.AddOutputContent("\"" + contentElement.TextValue.Replace("\"", "\"\"") + "\"");
                    break;

                case SqlStructureConstants.COMMA:
                case SqlStructureConstants.PERIOD:
                case SqlStructureConstants.SEMICOLON:
                case SqlStructureConstants.SCOPERESOLUTIONOPERATOR:
                case SqlStructureConstants.ASTERISK:
                case SqlStructureConstants.EQUALSSIGN:
                case SqlStructureConstants.OTHEROPERATOR:
                    state.SpaceExpected = false;
                    state.AddOutputContent(contentElement.TextValue);
                    break;

                case SqlStructureConstants.COMPOUNDKEYWORD:
                    state.AddOutputContent(FormatKeyword(contentElement.GetAttributeValue(SqlStructureConstants.ANAME_SIMPLETEXT)));
                    state.SpaceExpected = true;
                    break;


                case SqlStructureConstants.LABEL:
                    state.AddOutputContent(contentElement.TextValue);
                    state.BreakExpected = true;
                    break;

                case SqlStructureConstants.OTHERKEYWORD:
                case SqlStructureConstants.ALPHAOPERATOR:
                case SqlStructureConstants.DATATYPE_KEYWORD:
                case SqlStructureConstants.PSEUDONAME:
                case SqlStructureConstants.BINARY_VALUE:
                    state.AddOutputContent(FormatKeyword(contentElement.TextValue));
                    state.SpaceExpected = true;
                    break;

                case SqlStructureConstants.NUMBER_VALUE:
                    state.AddOutputContent(FormatKeyword(contentElement.TextValue));
                    if (!contentElement.TextValue.ToLowerInvariant().Contains("e"))
                    {
                        state.SpaceExpectedForE = true;
                        if (contentElement.TextValue.Equals("0"))
                            state.SpaceExpectedForX = true;
                    }
                    break;

                case SqlStructureConstants.MONETARY_VALUE:
                    if (!contentElement.TextValue.Substring(0, 1).Equals("$"))
                        state.SpaceExpected = false;

                    state.AddOutputContent(contentElement.TextValue);

                    if (contentElement.TextValue.Length == 1)
                        state.SpaceExpectedForPlusMinus = true;
                    break;

                case SqlStructureConstants.OTHERNODE:
                case SqlStructureConstants.FUNCTION_KEYWORD:
                    state.AddOutputContent(contentElement.TextValue);
                    state.SpaceExpected = true;
                    break;

                default:
                    throw new Exception("Unrecognized element in SQL Xml!");
            }
        }

        private string FormatKeyword(string keyword)
        {
            string outputKeyword;
            if (!KeywordMapping.TryGetValue(keyword.ToUpperInvariant(), out outputKeyword))
                outputKeyword = keyword;

            if (RandomizeCase)
                return GetCaseRandomized(outputKeyword);
            else
                return outputKeyword;
        }

        private string GetCaseRandomized(string outputKeyword)
        {
            char[] keywordCharArray = outputKeyword.ToCharArray();
            for (int i = 0; i < keywordCharArray.Length; i++)
            {
                if (_currentCaseLength == _currentCaseLimit)
                {
                    _currentCaseLimit = _randomizer.Next(MIN_CASE_WORD_LENGTH, MAX_CASE_WORD_LENGTH);
                    _currentlyUppercase = _randomizer.Next(0, 2) == 0;
                    _currentCaseLength = 0;
                }

                keywordCharArray[i] = _currentlyUppercase ? Char.ToUpperInvariant(keywordCharArray[i]) : Char.ToLowerInvariant(keywordCharArray[i]);
                _currentCaseLength++;
            }
            return new string(keywordCharArray);
        }

        class TSqlObfuscatingFormattingState : BaseFormatterState
        {
            public TSqlObfuscatingFormattingState(bool randomizeColor, bool randomizeLineLength)
                : base(randomizeColor)
            {
                RandomizeColor = randomizeColor;
                RandomizeLineLength = randomizeLineLength;

                if (RandomizeColor)
                {
                    _currentColorLimit = _randomizer.Next(MIN_COLOR_WORD_LENGTH, MAX_COLOR_WORD_LENGTH);
                    _currentColor = string.Format("#{0:x2}{1:x2}{2:x2}", _randomizer.Next(0, 127), _randomizer.Next(0, 127), _randomizer.Next(0, 127));
                }
                if (RandomizeLineLength)
                {
                    _thisLineLimit = _randomizer.Next(MIN_LINE_LENGTH, MAX_LINE_LENGTH);
                }
            }

            private const int MIN_COLOR_WORD_LENGTH = 3;
            private const int MAX_COLOR_WORD_LENGTH = 15;
            private const int MIN_LINE_LENGTH = 10;
            private const int MAX_LINE_LENGTH = 80;

            private bool RandomizeColor { get; set; }
            private bool RandomizeLineLength { get; set; }

            internal bool BreakExpected { get; set; }
            internal bool SpaceExpectedForAnsiString { get; set; }
            internal bool SpaceExpectedForE { get; set; }
            internal bool SpaceExpectedForX { get; set; }
            internal bool SpaceExpectedForPlusMinus { get; set; }
            internal bool SpaceExpected { get; set; }

            private Random _randomizer = new Random();
            private int _currentLineLength = 0;
            private int _thisLineLimit = MAX_LINE_LENGTH;

            private int _currentColorLength = 0;
            private int _currentColorLimit = MAX_COLOR_WORD_LENGTH;
            private string _currentColor = null;

            public void BreakIfExpected()
            {
                if (BreakExpected)
                {
                    BreakExpected = false;
                    base.AddOutputLineBreak();
                    SetSpaceNoLongerExpected();
                    _currentLineLength = 0;

                    if (RandomizeLineLength)
                        _thisLineLimit = _randomizer.Next(10, 80);
                }
            }

            public void SpaceIfExpectedForAnsiString()
            {
                if (SpaceExpectedForAnsiString)
                {
                    base.AddOutputContent(" ", null);
                    SetSpaceNoLongerExpected();
                }
            }

            public void SpaceIfExpected()
            {
                if (SpaceExpected)
                {
                    base.AddOutputContent(" ", null);
                    SetSpaceNoLongerExpected();
                }
            }

            public override void AddOutputContent(string content, string htmlClassName)
            {
                if (htmlClassName != null)
                    throw new NotSupportedException("Obfuscating formatter does not use html class names...");

                BreakIfExpected();
                SpaceIfExpected();
                if (_currentLineLength > 0 && _currentLineLength + content.Length > _thisLineLimit)
                {
                    BreakExpected = true;
                    BreakIfExpected();
                }
                else if ((SpaceExpectedForE && content.Substring(0, 1).ToLower().Equals("e"))
                    || (SpaceExpectedForX && content.Substring(0, 1).ToLower().Equals("x"))
                    || (SpaceExpectedForPlusMinus && content.Substring(0, 1).Equals("+"))
                    || (SpaceExpectedForPlusMinus && content.Substring(0, 1).Equals("-"))
                    )
                {
                    SpaceExpected = true;
                    SpaceIfExpected();
                }

                _currentLineLength += content.Length;
                if (RandomizeColor)
                {
                    int lengthWritten = 0;
                    while (lengthWritten < content.Length)
                    {
                        if (_currentColorLength == _currentColorLimit)
                        {
                            _currentColorLimit = _randomizer.Next(MIN_COLOR_WORD_LENGTH, MAX_COLOR_WORD_LENGTH);
                            _currentColor = string.Format("#{0:x2}{1:x2}{2:x2}", _randomizer.Next(0, 127), _randomizer.Next(0, 127), _randomizer.Next(0, 127));
                            _currentColorLength = 0;
                        }
                        
                        int writing;
                        if (content.Length - lengthWritten < _currentColorLimit - _currentColorLength)
                            writing = content.Length - lengthWritten;
                        else
                            writing = _currentColorLimit - _currentColorLength;

                        base.AddOutputContentRaw("<span style=\"color: ");
                        base.AddOutputContentRaw(_currentColor);
                        base.AddOutputContentRaw(";\">");
                        base.AddOutputContentRaw(Utils.HtmlEncode(content.Substring(lengthWritten, writing)));
                        base.AddOutputContentRaw("</span>");
                        lengthWritten += writing;
                        _currentColorLength += writing;
                    }
                }
                else
                {
                    base.AddOutputContent(content, null);
                }
                SetSpaceNoLongerExpected();
            }

            private void SetSpaceNoLongerExpected()
            {
                SpaceExpected = false;
                SpaceExpectedForAnsiString = false;
                SpaceExpectedForE = false;
                SpaceExpectedForX = false;
                SpaceExpectedForPlusMinus = false;
            }

            public override void AddOutputLineBreak()
            {
                //don't want the outer code to write line breaks at all
                throw new NotSupportedException();
            }
        }
    }
}
