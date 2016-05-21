using JBrick.Contracts;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Core
{
    public class UnityIoc : IIocContainer
    {
        IUnityContainer _container;

        public UnityIoc(IUnityContainer container)
        {
            _container = container;
        }

        public object Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
