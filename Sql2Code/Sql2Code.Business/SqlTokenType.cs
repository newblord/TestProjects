using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2Code.Business
{
    public enum SqlTokenType
    {
        RoutineModification,
        RoutineName,
        RoutineParameter,
        DeclareStatement,
        DeclareVariable,
        SetStatement,
        SetVariable
        //OpenParens,
        //CloseParens,
        //WhiteSpace,
        //OtherNode,
        //SingleLineComment,
        //SingleLineCommentCStyle,
        //MultiLineComment,
        //String,
        //NationalString,
        //BracketQuotedName,
        //QuotedString,
        //Comma,
        //Period,
        //Semicolon,
        //Colon,
        //Asterisk,
        //EqualsSign,
        //MonetaryValue,
        //Number,
        //BinaryValue,
        //OtherOperator,
        //PseudoName
    }
}
