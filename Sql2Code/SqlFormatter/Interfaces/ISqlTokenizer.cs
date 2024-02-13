namespace SqlFormatter.Interfaces
{
    public interface ISqlTokenizer
    {
        ITokenList TokenizeSQL(string inputSQL);
        ITokenList TokenizeSQL(string inputSQL, long? requestedMarkerPosition);
    }
}
