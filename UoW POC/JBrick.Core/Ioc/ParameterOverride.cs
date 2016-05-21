using JBrick.Contracts.IoC;

namespace JBrick.Core.IoC
{
    public class ParameterOverride : IParameterOverride
    {
        public ParameterOverride(string parameterName, object parameterValue)
        {
            ParameterName = parameterName;
            ParameterValue = parameterValue;
        }

        public string ParameterName { get; private set; }
        public object ParameterValue { get; private set; }
    }
}
