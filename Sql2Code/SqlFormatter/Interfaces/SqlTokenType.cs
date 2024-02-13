using System;

namespace SqlFormatter.Interfaces
{
    public enum SqlTokenType
    {
        OpenParens,
        CloseParens,
        WhiteSpace,
        OtherNode,
        SingleLineComment,
        SingleLineCommentCStyle,
        MultiLineComment,
        String,
        NationalString,
        BracketQuotedName,
        QuotedString,
        Comma,
        Period,
        Semicolon,
        Colon,
        Asterisk,
        EqualsSign,
        MonetaryValue,
        Number,
        BinaryValue,
        OtherOperator,
        PseudoName
    }
}