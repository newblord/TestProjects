namespace SqlFormatter.Tokenizers
{
    internal class SimplifiedStringReader
    {
        private char[] inputChars;
        private int nextCharIndex = 0;

        public SimplifiedStringReader(string inputString)
        {
            this.inputChars = inputString.ToCharArray();
        }

        internal int Read()
        {
            int nextChar = Peek();
            nextCharIndex++;
            return nextChar;
        }

        internal int Peek()
        {
            if (nextCharIndex < inputChars.Length)
                return inputChars[nextCharIndex];
            else
                return -1;
        }

        //note, intentional difference between index (zero-based) and position (1-based). Zero here means "nothing output yet".
        internal long LastCharacterPosition
        {
            get
            {
                if (nextCharIndex <= inputChars.Length)
                    return nextCharIndex;
                else
                    return inputChars.Length;
            }
        }
    }
}