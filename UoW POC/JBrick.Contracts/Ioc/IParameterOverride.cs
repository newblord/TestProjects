namespace JBrick.Contracts.IoC
{
    public interface IParameterOverride
    {
        string ParameterName { get; }
        object ParameterValue { get; }
    }
}
