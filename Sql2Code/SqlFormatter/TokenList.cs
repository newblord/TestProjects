using System;
using System.Collections.Generic;
using System.Text;
using SqlFormatter.Interfaces;

namespace SqlFormatter
{
    public class TokenList : List<IToken>, ITokenList
    {
        public bool HasUnfinishedToken { get; set; }
        
        public string PrettyPrint()
        {
            StringBuilder outString = new StringBuilder();
            foreach(IToken contentToken in this)
            {
                string tokenType = contentToken.Type.ToString();
                outString.Append(tokenType.PadRight(20));
                outString.Append(": ");
                outString.Append(contentToken.Value);
                if (contentToken.Equals(this.MarkerToken))
                {
                    outString.Append(" (MARKER - pos ");
                    outString.Append(this.MarkerPosition.ToString());
                    outString.Append(")");
                }
                outString.AppendLine();
            }
            return outString.ToString();
        }

        public new IList<IToken> GetRange(int index, int count)
        {
            return base.GetRange(index, count);
        }

        public IList<IToken> GetRangeByIndex(int fromIndex, int toIndex)
        {
            return this.GetRange(fromIndex, toIndex - fromIndex + 1);
        }

        public IToken MarkerToken { get; set; }

        public long? MarkerPosition { get; set; }
    }
}
