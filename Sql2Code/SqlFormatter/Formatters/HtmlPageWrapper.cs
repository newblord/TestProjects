using System;
using SqlFormatter.Interfaces;

namespace SqlFormatter.Formatters
{
    public class HtmlPageWrapper : ISqlTreeFormatter
    {
        ISqlTreeFormatter _underlyingFormatter;

        public HtmlPageWrapper(ISqlTreeFormatter underlyingFormatter)
        {
            if (underlyingFormatter == null)
                throw new ArgumentNullException("underlyingFormatter");

            _underlyingFormatter = underlyingFormatter;
        }

        private const string HTML_OUTER_PAGE = @"<!DOCTYPE html >
<html>
<head>
</head>
<body>
<style type=""text/css"">
.SQLCode {{
	font-size: 13px;
	font-weight: bold;
	font-family: monospace;;
	white-space: pre;
    -o-tab-size: 4;
    -moz-tab-size: 4;
    -webkit-tab-size: 4;
}}
.SQLComment {{
	color: #00AA00;
}}
.SQLString {{
	color: #AA0000;
}}
.SQLFunction {{
	color: #AA00AA;
}}
.SQLKeyword {{
	color: #0000AA;
}}
.SQLOperator {{
	color: #777777;
}}
.SQLErrorHighlight {{
	background-color: #FFFF00;
}}


</style>
<pre class=""SQLCode"">{0}</pre>
</body>
</html>
";

        public bool HTMLFormatted { get { return true; } }
        public string ErrorOutputPrefix { 
            get 
            { 
                return _underlyingFormatter.ErrorOutputPrefix; 
            } 
            set 
            {
                throw new NotSupportedException("Error output prefix should be set on the underlying formatter - it cannot be set on the Html Page Wrapper.");
            }
        }

        public string FormatSQLTree(SqlFormatter.ParseStructure.Node sqlTree)
        {
            string formattedResult = _underlyingFormatter.FormatSQLTree(sqlTree);
            if (_underlyingFormatter.HTMLFormatted)
                return string.Format(HTML_OUTER_PAGE, formattedResult);
            else
                return string.Format(HTML_OUTER_PAGE, Utils.HtmlEncode(formattedResult));
        }
    }
}
