using System.Collections.Generic;

namespace JBrick.Contracts.IoC
{
    public interface IIoC
    {
        T Resolve<T>();
        T Resolve<T>(params IParameterOverride[] constructorParameters);
        IEnumerable<T> ResolveAll<T>();
    }
}
