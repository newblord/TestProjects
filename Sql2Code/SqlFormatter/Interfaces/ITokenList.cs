using System;
using System.Collections.Generic;

namespace SqlFormatter.Interfaces
{
    public interface ITokenList : IList<IToken>
    {
        bool HasUnfinishedToken { get; set; }
        string PrettyPrint();
        IList<IToken> GetRange(int index, int count);
        IList<IToken> GetRangeByIndex(int fromIndex, int toIndex);
        IToken MarkerToken { get; }
        long? MarkerPosition { get; }
    }
}
