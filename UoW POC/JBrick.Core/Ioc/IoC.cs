using JBrick.Contracts.IoC;
using Microsoft.Practices.Unity;

namespace JBrick.Core.IoC
{
	public class IoC : IIoC
	{
		IUnityContainer _iocContainer;

		public IoC(IUnityContainer iocContainer)
		{
			_iocContainer = iocContainer;
		}

		public T Resolve<T>()
		{
			return _iocContainer.Resolve<T>();
		}

		public T Resolve<T>(params IParameterOverride[] constructorParameterOverrides)
		{
			var overrides = new ParameterOverrides();

			foreach (var parameter in constructorParameterOverrides)
			{
				overrides.Add(parameter.ParameterName, parameter.ParameterValue);
			}
			
			return _iocContainer.Resolve<T>(overrides);
		}

		public System.Collections.Generic.IEnumerable<T> ResolveAll<T>()
		{
			return _iocContainer.ResolveAll<T>();
		}
	}
}
