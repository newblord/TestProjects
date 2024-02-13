using System.Text;

namespace SqlFormatter
{
    public static class Utils
    {
        public static string HtmlEncode(string raw)
        {
            /*
             * This is a "Roll Your Own" implementation of HtmlEncode, which was necessary in the end because people want
             * to use the library with .Net 3.5 Client Profile and other restricted environments; the dependency on 
             * System.Web just for HtmlEncode was always a little disturbing anyway.
             * I've attempted to optimize the implementation towards strings that don't actually contain any special 
             * characters, and I've also skipped some of the more interesting stuff that I see in the MS implementation
             * (pointers, and some special handling in the WinAnsi special range of characters?), keeping it to the basic 
             * 4 "known bad" characters.
             */

            if (raw == null)
                return null;

            StringBuilder outBuilder = null;
            int latestCheckPos = 0;
            int latestReplacementPos = 0;

            foreach (char c in raw)
            {
                string replacementString = null;

                switch (c)
                {
                    case '>':
                        replacementString = "&gt;";
                        break;
                    case '<':
                        replacementString = "&lt;";
                        break;
                    case '&':
                        replacementString = "&amp;";
                        break;
                    case '"':
                        replacementString = "&quot;";
                        break;
                }

                if (replacementString != null)
                {
                    if (outBuilder == null)
                        outBuilder = new StringBuilder(raw.Length);

                    if (latestReplacementPos < latestCheckPos)
                        outBuilder.Append(raw.Substring(latestReplacementPos, latestCheckPos - latestReplacementPos));

                    outBuilder.Append(replacementString);

                    latestReplacementPos = latestCheckPos + 1;
                }

                latestCheckPos++;
            }

            if (outBuilder != null)
            {
                if (latestReplacementPos < latestCheckPos)
                    outBuilder.Append(raw.Substring(latestReplacementPos));

                return outBuilder.ToString();
            }
            else
                return raw;
        }

#if SIMPLIFIEDFW

        //Invariant conversions are not implemented in Bridge.Net and .Net Standard...
        public static string ToLowerInvariant(this string value) => value.ToLower();
        public static string ToUpperInvariant(this string value) => value.ToUpper();
        public static char ToLowerInvariant(this char value) => char.ToLower(value);
        public static char ToUpperInvariant(this char value) => char.ToUpper(value);

#endif

    }
}
